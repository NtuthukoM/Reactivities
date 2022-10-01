using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Domain;
using Reactivities.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Comments
{
    public class Create
    {
        public class Command: IRequest<Result<CommentDto>>
        {
            public string Body { get; set; }
            public int ActivityId { get; set; }
        }

        public class CommandValidator:AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Body).NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command, Result<CommentDto>>
        {
            private readonly ReactivitiesDataContext context;
            private readonly IMapper mapper;
            private readonly IUserAccessor userAccessor;

            public Handler(ReactivitiesDataContext context, IMapper mapper,
                IUserAccessor userAccessor)
            {
                this.context = context;
                this.mapper = mapper;
                this.userAccessor = userAccessor;
            }
            public async Task<Result<CommentDto>> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = await context.Activities.FindAsync(request.ActivityId);
                if (activity == null) return null;

                var user = await context.Users.Include(x => x.Photos)
                    .SingleOrDefaultAsync(x => x.UserName == userAccessor.GetUsername());

                var comment = new Comment()
                {
                    Author = user,
                    Activity = activity,
                    Body = request.Body
                };
                activity.Comments.Add(comment);
                var success = await context.SaveChangesAsync() > 0;
                if (success)
                {
                    return Result<CommentDto>.Success(mapper.Map<CommentDto>(comment));
                }
                else
                {
                    return Result<CommentDto>.Failure("Failed to create comment");
                }
            }
        }
    }
}

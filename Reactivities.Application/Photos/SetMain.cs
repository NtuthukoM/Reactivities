using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Photos
{
    public class SetMain
    {
        public class Command: IRequest<Result<Unit>>
        {
            public string Id { get; set; }
        }

        public class Handler: IRequestHandler<Command, Result<Unit>>
        {
            private readonly ReactivitiesDataContext context;
            private readonly IUserAccessor userAccessor;

            public Handler(ReactivitiesDataContext context, IUserAccessor userAccessor)
            {
                this.context = context;
                this.userAccessor = userAccessor;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await context.Users.Include(x => x.Photos)
                    .FirstOrDefaultAsync(x => x.UserName == userAccessor.GetUsername());
                if (user == null)
                    return null;

                var photo = user.Photos.FirstOrDefault(x => x.Id == request.Id);
                if (photo == null)
                    return null;

                var currentmain = user.Photos.FirstOrDefault(x => x.IsMain);
                if (currentmain != null)
                    currentmain.IsMain = false;
                photo.IsMain = true;
                var result = await context.SaveChangesAsync() > 0;
                if (result)
                {
                    return Result<Unit>.Success(Unit.Value);
                }
                else
                {
                    return Result<Unit>.Failure("Problem setting main photo");
                }
            }
        }
    }
}

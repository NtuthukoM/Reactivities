using AutoMapper;
using MediatR;
using Reactivities.Domain;
using Reactivities.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Activity Activity { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ReactivitiesDataContext context;
            private readonly IMapper mapper;

            public Handler(ReactivitiesDataContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var model = await context.Activities.FindAsync(request.Activity.Id);
                var activity = request.Activity;
                if(model != null)
                {
                    mapper.Map(activity, model);
                    model.Title = activity.Title ?? model.Title;
                    await context.SaveChangesAsync(); 
                }

                return Unit.Value;
            }
        }
    }
}

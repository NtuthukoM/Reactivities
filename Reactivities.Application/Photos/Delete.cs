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
    public class Delete
    {
        public class Command: IRequest<Result<Unit>>
        {
            public string Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly ReactivitiesDataContext context;
            private readonly IPhotoAccessor photoAccessor;
            private readonly IUserAccessor userAccessor;

            public Handler(ReactivitiesDataContext context, 
                IPhotoAccessor photoAccessor, IUserAccessor userAccessor)
            {
                this.context = context;
                this.photoAccessor = photoAccessor;
                this.userAccessor = userAccessor;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await context.Users.Include(x =>
                    x.Photos).FirstOrDefaultAsync(x => x.UserName == userAccessor.GetUsername());
                if(user != null)
                {
                    var photo = user.Photos.FirstOrDefault(x => x.Id == request.Id);
                    if(photo != null)
                    {
                        if (photo.IsMain)
                        {
                            return Result<Unit>.Failure("You cannot delete your main photo.");
                        }
                        var deleteResult = await photoAccessor.DeletePhoto(request.Id);
                        if (!string.IsNullOrEmpty(deleteResult))
                        {
                            user.Photos.Remove(photo);
                            var result = await context.SaveChangesAsync() > 0;
                            if (result)
                            {
                                return Result<Unit>.Success(Unit.Value);
                            }
                            else
                            {
                                return Result<Unit>.Failure("Problem deleting photo from API.");
                            }
                        }
                        else
                        {
                            return Result<Unit>.Failure("Problem deleting photo from Cloudinary");
                        }
                    }

                }
                return null;
            }
        }
    }
}

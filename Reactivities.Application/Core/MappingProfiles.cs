using AutoMapper;
using Reactivities.Application.Activities;
using Reactivities.Application.Comments;
using Reactivities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Core
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, Activity>();
            CreateMap<Activity, ActivityDto>()
                .ForMember(d => d.HostUsername, opt =>
                    opt.MapFrom(q => q.Attendees.FirstOrDefault(x => x.IsHost).AppUser.UserName));
            CreateMap<ActivityAttendee, AttendeeDto>()
                .ForMember(d => d.DisplayName, opt => opt.MapFrom(x => x.AppUser.DisplayName))
                .ForMember(d => d.Username, opt => opt.MapFrom(x => x.AppUser.UserName))
                .ForMember(d => d.Bio, opt => opt.MapFrom(x => x.AppUser.Bio))
                .ForMember(x => x.Image, o => o.MapFrom(u => 
                                u.AppUser.Photos.FirstOrDefault(x => x.IsMain).Url));

            CreateMap<AppUser, Profiles.Profile>()
                .ForMember(x => x.Image, o => o.MapFrom(u => u.Photos.FirstOrDefault(x => x.IsMain).Url));

            CreateMap<Comment, CommentDto>()
                .ForMember(c => c.Username, o => o.MapFrom(u => u.Author.UserName))
                .ForMember(c => c.DisplayName, o => o.MapFrom(u => u.Author.DisplayName))
                .ForMember(c => c.Image, o => o.MapFrom(u => u.Author.Photos.FirstOrDefault(x => x.IsMain).Url));

        }
    }
}

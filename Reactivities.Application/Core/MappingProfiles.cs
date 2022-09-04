using AutoMapper;
using Reactivities.Application.Activities;
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
            CreateMap<ActivityAttendee, Profiles.Profile>()
                .ForMember(d => d.DisplayName, opt => opt.MapFrom(x => x.AppUser.DisplayName))
                .ForMember(d => d.Username, opt => opt.MapFrom(x => x.AppUser.UserName))
                .ForMember(d => d.Bio, opt => opt.MapFrom(x => x.AppUser.Bio));
                
        }
    }
}

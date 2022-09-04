using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reactivities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Persistance.Configuration
{
    internal class ActivityAttendeeSeed : IEntityTypeConfiguration<ActivityAttendee>
    {
        public void Configure(EntityTypeBuilder<ActivityAttendee> builder)
        {
            builder.HasData(
                    new ActivityAttendee
                    {
                        AppUserId = "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                        ActivityId = 1,
                        IsHost = true
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                        ActivityId = 2,
                        IsHost = true
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                        ActivityId = 2,
                        IsHost = false
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                        ActivityId = 3,
                        IsHost = true
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                        ActivityId = 3,
                        IsHost = false
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                        ActivityId = 4,
                        IsHost = true
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                        ActivityId = 4,
                        IsHost = false
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                        ActivityId = 5,
                        IsHost = true
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                        ActivityId = 5,
                        IsHost = false
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                        ActivityId = 6,
                        IsHost = true
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                        ActivityId = 7,
                        IsHost = true
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                        ActivityId = 7,
                        IsHost = false
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                        ActivityId = 8,
                        IsHost = true
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                        ActivityId = 8,
                        IsHost = false
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                        ActivityId = 9,
                        IsHost = true
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                        ActivityId = 9,
                        IsHost = false
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                        ActivityId = 10,
                        IsHost = true
                    },
                    new ActivityAttendee
                    {
                        AppUserId = "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                        ActivityId = 10,
                        IsHost = false
                    }
                    );
        }
    }
}

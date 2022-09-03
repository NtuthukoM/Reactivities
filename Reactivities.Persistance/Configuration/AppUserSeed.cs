using Microsoft.AspNetCore.Identity;
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
    internal class AppUserSeed : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();
            builder.HasData(new AppUser[]{new AppUser
            {
                Id = "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                Email = "bob@example.com",
                NormalizedEmail = "BOB@EXAMPLE.COM",
                UserName = "bob@example.com",
                NormalizedUserName = "BOB@EXAMPLE.COM",
                PasswordHash = hasher.HashPassword(null, "hkkjERD$#218ih"),
                EmailConfirmed = true,
                DisplayName = "Bob"
            }, new AppUser
            {
                Id = "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                Email = "jane@example.com",
                NormalizedEmail = "JANE@EXAMPLE.COM",
                UserName = "jane@example.com",
                NormalizedUserName = "JANE@EXAMPLE.COM",
                PasswordHash = hasher.HashPassword(null, "hkkjERD$#218ih"),
                EmailConfirmed = true,
                DisplayName = "Jane"
            } , new AppUser
            {
                Id = "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                Email = "tom@example.com",
                NormalizedEmail = "TOM@EXAMPLE.COM",
                UserName = "tom@example.com",
                NormalizedUserName = "TOM@EXAMPLE.COM",
                PasswordHash = hasher.HashPassword(null, "hkkjERD$#218ih"),
                EmailConfirmed = true,
                DisplayName = "Tom"
            }
            });
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reactivities.Domain;
using Reactivities.Persistance.Configuration;

namespace Reactivities.Persistance
{
    public class ReactivitiesDataContext:IdentityDbContext<AppUser>
    {
        public ReactivitiesDataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ActivityAttendee>(x => x.HasKey(a => 
                    new { a.ActivityId, a.AppUserId }));

            modelBuilder.Entity<ActivityAttendee>()
                .HasOne(x => x.AppUser)
                .WithMany(x => x.Activities)
                .HasForeignKey(x => x.AppUserId);

            modelBuilder.Entity<ActivityAttendee>()
                .HasOne(x => x.Activity)
                .WithMany(x => x.Attendees)
                .HasForeignKey(x => x.ActivityId);


            modelBuilder.ApplyConfiguration(new AppUserSeed());
            modelBuilder.ApplyConfiguration(new ActivitySeed());
            modelBuilder.ApplyConfiguration(new ActivityAttendeeSeed());
        }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityAttendee> ActivityAttendees { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
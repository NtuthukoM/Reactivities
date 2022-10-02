using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reactivities.Domain;
using Reactivities.Persistance.Configuration;

namespace Reactivities.Persistance
{
    public class ReactivitiesDataContext:IdentityDbContext<AppUser>
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityAttendee> ActivityAttendees { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserFollowing> UserFollowings { get; set; }

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

            //If an activity is deleted, the delete will cascade to the related comments:
            modelBuilder.Entity<Comment>()
                .HasOne(a => a.Activity)
                .WithMany(c => c.Comments)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserFollowing>(b => {
                b.HasKey(x => new { x.ObserverId, x.TargetId });

                b.HasOne(o => o.Observer)
                .WithMany(o => o.Followers)
                .HasForeignKey(f => f.ObserverId)
                .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Target)
                .WithMany(o => o.Followings)
                .HasForeignKey(f => f.TargetId)
                .OnDelete(DeleteBehavior.NoAction);
            });


            modelBuilder.ApplyConfiguration(new AppUserSeed());
            modelBuilder.ApplyConfiguration(new ActivitySeed());
            modelBuilder.ApplyConfiguration(new ActivityAttendeeSeed());
        }

    }
}
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
            modelBuilder.ApplyConfiguration(new ActivitySeed());
            modelBuilder.ApplyConfiguration(new AppUserSeed());
        }
        public DbSet<Activity> Activities { get; set; }
    }
}
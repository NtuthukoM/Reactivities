using Microsoft.EntityFrameworkCore;
using Reactivities.Domain;

namespace Reactivities.Persistance
{
    public class ReactivitiesDataContext:DbContext
    {
        public ReactivitiesDataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ActivitySeed());
        }
        public DbSet<Activity> Activities { get; set; }
    }
}
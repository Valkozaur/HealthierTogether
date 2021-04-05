namespace HealthierTogether.Server.Data
{
    using HealthierTogether.Server.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class HealthierTogetherDbContext : IdentityDbContext<User>
    {
        public HealthierTogetherDbContext(DbContextOptions<HealthierTogetherDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }

        public DbSet<Tag> Tag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasIndex(e => e.Name);

            base.OnModelCreating(modelBuilder);
        }
    }
}

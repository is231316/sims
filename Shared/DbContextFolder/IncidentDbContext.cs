using Microsoft.EntityFrameworkCore;
using Shared.Model;

namespace Shared.DbContextFolder
{
    public class IncidentDbContext : DbContext
    {
        public IncidentDbContext(DbContextOptions<IncidentDbContext> options) : base(options) { }

        public DbSet<Incident> Incidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Incident entity to match MySQL column names
            modelBuilder.Entity<Incident>(entity =>
            {
                entity.Property(e => e.IncidentDate).HasColumnName("incident_date");
                entity.Property(e => e.Title).HasColumnName("title");
                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IncidentType)
                    .HasColumnName("incident_type")
                    .HasConversion<string>();

                entity.Property(e => e.IsClosed).HasColumnName("is_closed");
                entity.Property(e => e.CreatedAt).HasColumnName("created_at");
                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });
        }
    }
}

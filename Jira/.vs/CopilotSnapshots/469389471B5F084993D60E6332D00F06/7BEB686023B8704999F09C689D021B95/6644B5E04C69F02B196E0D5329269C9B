using Microsoft.EntityFrameworkCore;

namespace JiraClone.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Project> Projects => Set<Project>();

        public DbSet<Board> Boards { get; set; }

        public DbSet<WorkItem> WorkItems { get; set; }

        public DbSet<StatusConfig> StatusConfigs { get; set; }

    }
}

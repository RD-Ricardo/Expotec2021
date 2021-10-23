using Expotec2021.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Expotec2021.Infra.Data.context
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        public DbSet<CategoryLaunch> categoryLaunches {get; set;}
        public DbSet<Jobs> jobs {get; set;}
        public DbSet<Launchs> launchs {get; set;}
        public DbSet<ListTask> listTasks {get; set;}
        public DbSet<Posts> posts {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
        }

    }
}
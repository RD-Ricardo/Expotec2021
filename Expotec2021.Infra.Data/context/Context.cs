using Expotec2021.Domain.Entities;
using Expotec2021.Infra.Identity.models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Expotec2021.Infra.Data.context
{
    public class Context : IdentityDbContext<User>
    {
        
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<Accounts> accounts {get; set;}
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
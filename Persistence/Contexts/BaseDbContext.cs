using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts
{
    public class BaseDbContext:DbContext
    {
        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration):base(dbContextOptions)
        {
            Configuration = configuration;
            Database.EnsureCreated();
        }
        protected IConfiguration Configuration { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
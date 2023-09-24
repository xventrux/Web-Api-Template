using API.DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccess
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

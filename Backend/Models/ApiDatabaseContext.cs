using Microsoft.EntityFrameworkCore;
namespace Backend.Models
{
    public class ApiDatabaseContext : DbContext
    {
        public ApiDatabaseContext(DbContextOptions<ApiDatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;

    }
}

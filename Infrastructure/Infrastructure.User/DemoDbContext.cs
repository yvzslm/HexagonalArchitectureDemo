using Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.User
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}

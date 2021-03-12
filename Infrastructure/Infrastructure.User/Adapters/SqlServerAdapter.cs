using Domain.User;
using Domain.User.Ports.Outgoing;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infrastructure.User
{
    public class SqlServerAdapter : IUserRepository
    {
        private DemoDbContext _dbContext;
        private DbSet<UserEntity> _dbSet;

        public SqlServerAdapter(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<UserEntity>();
        }

        public async Task<UserEntity> AddAsync(UserEntity user)
        {
            var entry = await _dbSet.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            var id = entry.Entity.ID;
            return new UserEntity(id, user.FirstName, user.LastName, user.Email, user.GsmNo);
        }
    }
}

using Domain.User;
using Domain.User.Ports.Outgoing;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.User
{
    public class UserRepository : IUserRepository
    {
        private DemoDbContext _dbContext;
        private DbSet<UserEntity> _dbSet;

        public UserRepository(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<UserEntity>();
        }

        public UserEntity Add(UserEntity user)
        {
            var entry = _dbSet.Add(user);
            _dbContext.SaveChanges();
            var id = entry.Entity.ID;
            return new UserEntity(id, user.FirstName, user.LastName, user.Email, user.GsmNo);
        }
    }
}

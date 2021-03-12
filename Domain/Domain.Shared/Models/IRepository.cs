using System.Threading.Tasks;

namespace Domain.Shared.Models
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> AddAsync(T entity);
    }
}

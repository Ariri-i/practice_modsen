
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        Task<T> GetById(int Id);

        Task<List<T>> GetAll();
    }
}

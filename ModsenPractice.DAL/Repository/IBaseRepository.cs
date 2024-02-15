namespace ModsenPractice.DAL.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task Add(T entity);

        Task HardDelete(int Id);

        Task Update(T entity);

        Task<T> GetById(int Id);

        Task<List<T>> GetAll();
    }
}

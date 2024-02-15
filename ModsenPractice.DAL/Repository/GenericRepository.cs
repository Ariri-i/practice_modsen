using Microsoft.EntityFrameworkCore;

namespace ModsenPractice.DAL.Repository
{
    public class GenericRepository<T>(dbContext dbContext): IBaseRepository<T> where T : class
    {
        private readonly dbContext _dbContext = dbContext;
        private readonly DbSet<T> _dbSet = dbContext.Set<T>();


        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbContext.Entry(entity).State = EntityState.Modified;

            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task HardDelete(int Id)
        {
            var entity = await GetById(Id);

            if (entity != null)
            {
                if (_dbContext.Entry(entity).State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }

                _dbSet.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAll() => await _dbSet.ToListAsync();

        public async Task<T> GetById(int Id) => await _dbSet.FindAsync(Id) ?? throw new Exception($"Entity wasn't found using the given id - {Id}.");
    }
}

using ModsenPractice.DAL.Models;

namespace ModsenPractice.DAL.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task SoftDelete(int Id);
    }
}

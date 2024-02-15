using ModsenPractice.DAL.Models;

namespace ModsenPractice.DAL.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task SoftDelete(int Id);
    }
}

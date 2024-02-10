using ModsenPractice.DAL.Models;

namespace ModsenPractice.DAL.Repository.ProductCategoryRepository
{
    public interface IProductCategoryRepository:IBaseRepository<ProductCategory>
    {
        List<ProductCategory> GetFullList();
    }
}
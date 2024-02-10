using ModsenPractice.DAL.Models;

namespace ModsenPractice.DAL.Repository.OrderProductRepository
{
    public interface IOrderProductRepository : IBaseRepository<OrderProduct>
    {
        List<OrderProduct> GetFullList();
    }
}

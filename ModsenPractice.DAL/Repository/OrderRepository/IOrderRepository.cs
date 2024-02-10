using ModsenPractice.DAL.Models;

namespace ModsenPractice.DAL.Repository.OrderRepository
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        List<Order> GetFullList();
    }
}

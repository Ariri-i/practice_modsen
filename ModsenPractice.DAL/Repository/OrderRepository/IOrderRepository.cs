using ModsenPractice.DAL.Models;

namespace ModsenPractice.DAL.Repository.OrderRepository
{
    public interface IOrderRepository
    {
        Task SoftDelete(int Id);
    }
}

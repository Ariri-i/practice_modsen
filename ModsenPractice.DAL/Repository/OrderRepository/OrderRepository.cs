using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.OrderRepository
{
    public class OrderRepository(dbContext dbContext) : GenericRepository<Order>(dbContext), IOrderRepository
    {
        public async Task SoftDelete(int Id)
        {
            var order = await GetById(Id);
            if (order != null)
            {
                order.IsDeleted = true;
                await Update(order);
            }
        }
    }
}

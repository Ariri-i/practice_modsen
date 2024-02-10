using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly dbContext _dbContext;

        public OrderRepository(dbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Add(Order Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order Entity)
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetFullList()
        {
            throw new NotImplementedException();
        }

        public void Update(Order Entity)
        {
            throw new NotImplementedException();
        }
    }
}

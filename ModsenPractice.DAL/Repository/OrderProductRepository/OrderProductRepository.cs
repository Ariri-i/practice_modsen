using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.OrderProductRepository
{
    public class OrderProductRepository : IOrderProductRepository
    {
        private readonly dbContext _dbContext;

        public OrderProductRepository(dbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Add(OrderProduct Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrderProduct Entity)
        {
            throw new NotImplementedException();
        }

        public OrderProduct GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderProduct> GetFullList()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderProduct Entity)
        {
            throw new NotImplementedException();
        }
    }
}

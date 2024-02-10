using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly dbContext _dbContext;

        public ProductRepository(dbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Add(Product Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product Entity)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetFullList()
        {
            throw new NotImplementedException();
        }

        public void Update(Product Entity)
        {
            throw new NotImplementedException();
        }
    }
}

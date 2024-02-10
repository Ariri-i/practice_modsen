using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.ProductCategoryRepository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly dbContext _dbContext;

        public ProductCategoryRepository(dbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Add(ProductCategory Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductCategory Entity)
        {
            throw new NotImplementedException();
        }

        public ProductCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductCategory> GetFullList()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductCategory Entity)
        {
            throw new NotImplementedException();
        }
    }
}

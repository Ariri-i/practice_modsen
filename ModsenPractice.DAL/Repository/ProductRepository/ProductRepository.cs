using ModsenPractice.DAL.Models;
using ModsenPractice.DAL.Repository.ProductCategoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.ProductRepository
{
    public class ProductRepository(dbContext dbContext) : GenericRepository<Product>(dbContext), IProductRepository
    {
        public async Task SoftDelete(int Id)
        {
            var product = await GetById(Id);
            if (product != null)
            {
                product.IsDeleted = true;
                await Update(product);
            }
        }
    }
}

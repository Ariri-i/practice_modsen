using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.ProductCategoryRepository
{
    public class ProductCategoryRepository(dbContext dbContext) : GenericRepository<ProductCategory>(dbContext), IProductCategoryRepository
    {
        private readonly dbContext _dbContext = dbContext;
    }
}

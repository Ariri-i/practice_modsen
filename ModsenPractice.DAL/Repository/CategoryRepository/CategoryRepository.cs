using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.CategoryRepository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly dbContext _dbContext;

        public CategoryRepository(dbContext dbContext) : base(dbContext) 
        {
            _dbContext = dbContext;
        }



    }
}

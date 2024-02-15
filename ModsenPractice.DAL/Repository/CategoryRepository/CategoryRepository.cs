using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.CategoryRepository
{
    public class CategoryRepository(dbContext dbContext) : GenericRepository<Category>(dbContext), ICategoryRepository
    {
        public async Task SoftDelete(int Id)
        {
            var category = await GetById(Id);
            if (category != null)
            {
                category.IsDeleted = true;
                await Update(category);
            }
        }
    }
}

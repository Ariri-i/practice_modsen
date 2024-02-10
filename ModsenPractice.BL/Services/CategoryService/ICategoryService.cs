using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.BL.Services.CategoryService
{
    public interface ICategoryService
    {
        public void GetCategoryList();

        public void AddCategory();

        public void UpdateCategory();

        public void DeleteCategory();
    }
}

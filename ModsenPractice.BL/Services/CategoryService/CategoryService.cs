using System;
using System.Collections.Generic;
using System.Linq;
using ModsenPractice.DAL.Repository.CategoryRepository;
using ModsenPractice.DAL.Models;

namespace ModsenPractice.BL.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory()
        {
            var category = new Category();
            _categoryRepository.Add(category);
        }

        public void DeleteCategory()
        {
           int Id = 0;
            var category = _categoryRepository.GetById(Id);
            _categoryRepository.Delete(category);
        }

        public void GetCategoryList()
        {
            List<Category> list = _categoryRepository.GetFullList();
        }

        public void UpdateCategory()
        {
            int Id = 0;
            var category = _categoryRepository.GetById(Id);
            _categoryRepository.Update(category);
        }
    }
}

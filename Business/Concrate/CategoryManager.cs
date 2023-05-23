using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void Add(Category category)
        {
            _categoryDAL.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public List<Category> GetCategories()
        {
            return _categoryDAL.GetAll();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _categoryDAL.Get(c => c.Id == categoryId);
        }

        public void Update(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}

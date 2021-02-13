using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;// 
       
        public CategoryManager(ICategoryDal categoryDal)//Constructor
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            //Select * from Catogories where CategoryId=3
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}

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
        //Bağımlılığımı constructor injection ile yapıyorum
        ICategoryDal _categoryDal;

        public CategoryManager (ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            //İş kodları
            return _categoryDal.GetAll();
        }

        //Select * from Categories where CategoryId = x
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get( c => c.CategoryId == categoryId);
        }

       
    }
}

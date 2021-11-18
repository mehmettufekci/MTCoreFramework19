﻿using MTFramework.Business.Abstract;
using MTFramework.Business.Constants;
using MTFramework.Core.Utilities.Results;
using MTFramework.DataAccess.Abstract;
using MTFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTFramework.Business.Concrete
{
    public class CategoryManager: ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId == categoryId));
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }

        //public IResult Add(Category category)
        //{
        //    _categoryDal.Add(category);
        //    return new SuccessResult(Messages.CategoryAdded);
        //}

        //public IResult Delete(Category category)
        //{
        //    _categoryDal.Delete(category);
        //    return new SuccessResult(Messages.CategoryDeleted);
        //}
        //public IResult Update(Category category)
        //{
        //    _categoryDal.Update(category);
        //    return new SuccessResult(Messages.CategoryUpdated);
        //}
    }
}

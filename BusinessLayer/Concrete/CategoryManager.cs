﻿using BusinessLayer.Abstruct;
using DataAccsessLayer.Abstruct;
using DataAccsessLayer.Contrete.EntityFramework;
using DataAccsessLayer.Repository;
using EntityLayer.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;


        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {

            _categoryDal.Insert(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
        public Category GetById(int id)
        {
           return _categoryDal.GetById(id);
        }



        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}

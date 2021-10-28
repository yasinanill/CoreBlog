﻿using BusinessLayer.Abstruct;
using DataAccsessLayer.Abstruct;
using EntityLayer.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
 public   class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogbyId(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);

        }
        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }

    }
}

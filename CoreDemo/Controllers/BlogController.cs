using BusinessLayer.Concrete;
using DataAccsessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var degerler = bm.GetBlogListCategory();
            return View(degerler);
        }
        public IActionResult BlogReadAll(int id)
        {
            var values = bm.GetBlogbyId(id);
            return View(values);

        }
    }
}

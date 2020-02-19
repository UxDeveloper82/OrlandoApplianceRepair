using ApplianceRepair.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplianceRepair.Controllers
{
    public class MyBlogsController : Controller
    {
        private ApplicationDbContext _context;

        public MyBlogsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: MyBlogs
        public ActionResult Index()
        {
            var myblogs = _context.MyBlogs.ToList();
            return View(myblogs);
        }

        public ActionResult Details(int id) 
        {
            var myblog = _context.MyBlogs.SingleOrDefault(b => b.Id == id);

            if (myblog == null)
                return HttpNotFound();

            return View(myblog);
        }
    }
}
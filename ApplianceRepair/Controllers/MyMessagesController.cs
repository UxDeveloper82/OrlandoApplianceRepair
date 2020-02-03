using ApplianceRepair.Models;
using ApplianceRepair.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplianceRepair.Controllers
{
    public class MyMessagesController : Controller
    {
        private ApplicationDbContext _context;

        public MyMessagesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: MyMessages
        [Authorize]
        public ActionResult Index()
        {
            var mymessages = _context.MyMessages.ToList();
            return View(mymessages);
        }

        public ActionResult New()
        {
            var viewModel = new MyMessagesViewModel();

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(MyMessage mymessage)
        {
            _context.MyMessages.Add(mymessage);
            _context.SaveChanges();
            return RedirectToAction("Index","Home");
        }



    }
}
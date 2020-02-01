using ApplianceRepair.Models;
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
        public ActionResult Index()
        {
            var mymessages = _context.MyMessages.ToList();
            return View(mymessages);
        }

        public ActionResult SendMessageForm()
        {

            return View();
        }

    }
}
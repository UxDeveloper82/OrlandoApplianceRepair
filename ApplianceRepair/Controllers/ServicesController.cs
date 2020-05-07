using ApplianceRepair.Models;
using ApplianceRepair.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplianceRepair.Controllers
{
    public class ServicesController : Controller
    {
        private ApplicationDbContext _context;

        public ServicesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Services
        public ActionResult Index()
        {
            var services = _context.Services.ToList();
            return View(services);
        }

         public ActionResult New()
         {
             var viewModel = new ServiceFormViewModel()
                {
                    Service = new Service()
                };

              return View("serviceForm", viewModel);
          
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Service service)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ServiceFormViewModel
                {
                    Service = service

                };
                return View("ServiceForm", viewModel);
            }
            if (service.Id == 0)
                _context.Services.Add(service);
            else
            {
                var serviceInDb = _context.Services.Single(s => s.Id == service.Id);
                serviceInDb.Id = service.Id;
                serviceInDb.Type = service.Type;
                serviceInDb.Description = service.Description;
                serviceInDb.Price = service.Price;
                service.GetDays = service.GetDays;
                serviceInDb.ImageUrl = service.ImageUrl;

            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Services");

        }



    }
}
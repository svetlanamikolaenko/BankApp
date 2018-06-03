using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankApp.Models;
using BankApp.View_models;

namespace BankApp.Controllers
{
    public class ManagersController : Controller
    {
        private ApplicationDbContext _context;

        public ManagersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Managers
        public ActionResult Random()
        {
            var manager = new Manager() {LastName = "Shrek"};
            return View(manager);
        }

        public ViewResult Index()
        {
            var managers = _context.Managers.Include(m => m.Role).ToList();

            return View(managers);
        }

        public ActionResult Details(int id)
        {
            var manager = _context.Managers.SingleOrDefault(c => c.Id == id);

            if (manager == null)
                return HttpNotFound();

            return View(manager);
        }

        public ActionResult New()
        {
            var role = _context.Roles.ToList();
            var viewModel = new NewManagerViewModel
            {
                Role = role
            };

            return View(viewModel);
        }
    }
}
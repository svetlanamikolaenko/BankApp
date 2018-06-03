using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers
{
    public class LoansController : Controller
    {
        // GET: Loans
        public ActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers
{
    public class DepositsController : Controller
    {
        // GET: Deposits
        public ActionResult Index()
        {
            return View();
        }
    }
}
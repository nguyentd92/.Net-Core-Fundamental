using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Customers/Count")]

        public string CustomerCount()
        {
            return "You have 4 customers";
        }

        [Route("Customers/{id?}")]

        public string CustomerInfo(int id)
        {
            return "Customer " + id + "information";
        }
    }
}
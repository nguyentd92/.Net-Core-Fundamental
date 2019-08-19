using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexModel();
            model.Message = "Hello from Model!!";
            return View(model);
        }

        [ActionName("Modify")]
        public string Edit()
        {
            return "Call Modify";
        }

        [HttpPut("{id}")]
        public IActionResult Update(IndexModel model)
        {
            return RedirectToAction("Index");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete()
        {
            return RedirectToAction("Index");
        }

        [NonAction]
        public string NonAction()
        {
            return "Will not call";
        }
    }
}
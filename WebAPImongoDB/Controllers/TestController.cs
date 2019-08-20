using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPImongoDB.Models;

namespace WebAPImongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Json(new TestModel()
            {
                Id = "1",
                Title = "Noi dung"
            });
        }

        [HttpGet("check")]
        public JsonResult Check()
        {
            return Json(new TestModel()
            {
                Id = "2",
                Title = "Noi dung Test"
            });
        }
    }
}
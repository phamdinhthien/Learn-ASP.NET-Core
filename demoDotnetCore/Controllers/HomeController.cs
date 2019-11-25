using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoDotnetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoDotnetCore.Controllers
{
    //[Route("common")]
    public class HomeController : Controller
    {
        [Route("Home")]
        [Route("Home-1-2-3")]
        public IActionResult Index(int id)
        {
            var model = new IndexModel();
            model.Message = "this is message " + id;
            return View(model);
        }

        [Route("")]
        public string getString()
        {
            return "ok ok";
        }

        [Route("get/{id:int?}")]
        public string getParam(int id)
        {
            return "ok ok " + id;
        }
    }
}
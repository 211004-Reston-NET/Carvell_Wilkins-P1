using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CRUSWebUI.Controllers
{
    public class TestControler : Controller
    {
            
        public IActionResult Index()
        {
            return View();
        }
    }
}

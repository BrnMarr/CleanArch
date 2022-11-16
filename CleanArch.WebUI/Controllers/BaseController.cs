using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.WebUI.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index(FromFormAttribute form)
        {
            return View();
        }
    }
}

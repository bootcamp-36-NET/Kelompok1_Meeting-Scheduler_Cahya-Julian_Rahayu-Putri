using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class DashboardController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44377/api/")
        };
        public IActionResult Index()
        {
            if (HttpContext.Session.IsAvailable)
            {
                return View();
            }
            return RedirectToAction("Login", "AccountWeb");
        }
    }
}

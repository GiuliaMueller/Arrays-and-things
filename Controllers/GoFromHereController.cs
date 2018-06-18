using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BudgetApp.Controllers
{
    public class GoFromHereController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Snowball()
        {
            return View();
        }

        public IActionResult Avalanche()
        {
            return View();
        }

        public IActionResult Hybrid()
        {
            return View();
        }
    }
}

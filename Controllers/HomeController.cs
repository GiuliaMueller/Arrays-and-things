using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BudgetApp.Data;
using BudgetApp.Models;
using BudgetApp.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace BudgetApp.Controllers
{
    public class HomeController : Controller
    {
        //const string SessionName = "Name";

            private BudgetAppDbContext context;
        
        public HomeController(BudgetAppDbContext dbContext)
        {
            context = dbContext;
        }

       public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Use this app to list incomes, expenses, savings goals and learn about debt payoff strategies.";

            return View();
        }

        /*public IActionResult Contact()
        {
            ViewData["Message"] = "Enter contact information on this page";

            return View();
        }*/

        
        public IActionResult LogIn()
        {
            AddLogInViewModel addLogInViewModel = new AddLogInViewModel();
            return View(addLogInViewModel);
        }

        [HttpPost]
        public IActionResult LogIn(AddLogInViewModel addLogInViewModel)
        {
            if (ModelState.IsValid)
            {
               User newLogIn = new User
                {
                    LogInName = addLogInViewModel.LogInName
                };

                context.Users.Add(newLogIn);
                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(addLogInViewModel);
        }

        public IActionResult Registration()
        {
            AddRegistrationViewModel addRegistrationViewModel = new AddRegistrationViewModel();
            return View();
        }


        [HttpPost]
        public IActionResult Registration(AddRegistrationViewModel addRegistrationViewModel)
        {
            if (ModelState.IsValid)
            {
                User newRegistration = new User
                {
                    LogInName = addRegistrationViewModel.LogInName
                };

                context.Users.Add(newRegistration);
                context.SaveChanges();

                return Redirect("/Home/Index");
            }
            return View(addRegistrationViewModel);
        }

        public IActionResult Logout()
        {
            return View();
        }



        

        /* public IActionResult Error()
         {
             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
         }*/
    }
}

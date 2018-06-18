using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BudgetApp.Models;
using BudgetApp.ViewModels;
using BudgetApp.Data;

namespace BudgetApp.Controllers
{
    public class IncomeController : Controller
    {
        private BudgetAppDbContext context;

        public IncomeController(BudgetAppDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Income> incomes = context.Incomes.ToList();

            return View(incomes);
        }

        public IActionResult AddIncome()
        {
            AddIncomeViewModel addIncomeViewModel = new AddIncomeViewModel();
            return View(addIncomeViewModel);
        }

        [HttpPost]
        public IActionResult AddIncome(AddIncomeViewModel addIncomeViewModel)
        {

            if (ModelState.IsValid)
            {
                Income newIncome = new Income
                {
                    Name = addIncomeViewModel.Name,
                    Amount = addIncomeViewModel.Amount,
                    Type = addIncomeViewModel.Type
                };
                
                context.Incomes.Add(newIncome);
                context.SaveChanges();

                return Redirect("/Income/Index");
            }

            return View(addIncomeViewModel);
        }
        
        public IActionResult Remove()
        {
            ViewBag.title = "Remove Income";
            ViewBag.incomes = context.Incomes.ToList();
            return View();
        }
       
        [HttpPost]
        public IActionResult Remove(int[] incomeIds)
        {
            foreach (int incomeId in incomeIds)
                {
                Income theIncome = context.Incomes.Single(i => i.IncomeID == incomeId);
                context.Incomes.Remove(theIncome);
                }

            context.SaveChanges();

            return Redirect("/Income");
        }

    }



    /* alter the route for the IAction this will put in at a different page
     * [Route("/Hello/Aloha")]
*/

    /*
     customize routes so they can accept paramaeters as a query string.  
     (Get request with a query paramater)
    */



}

    /* post requests
     */



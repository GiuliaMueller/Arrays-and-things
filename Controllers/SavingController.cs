using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetApp.Data;
using BudgetApp.Models;
using BudgetApp.ViewModels;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BudgetApp.Controllers
{
    public class SavingController : Controller
    {

        private BudgetAppDbContext context;

        public SavingController(BudgetAppDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Saving> savings = context.Savings.ToList();

            return View(savings);
        }



      /*  [HttpGet]
        public IActionResult Saving()
        {

            List<Saving> savings = SavingData.GetAll();

            return View(savings);

        }*/



        public IActionResult AddSaving()
        {
            AddSavingViewModel addSavingViewModel = new AddSavingViewModel();
            return View(addSavingViewModel);
        }



        [HttpPost]
        public IActionResult AddSaving(AddSavingViewModel addSavingViewModel)
        {
            if (ModelState.IsValid)
            {
                Saving newSaving = new Saving
                {
                    Name = addSavingViewModel.Name,
                    Amount = addSavingViewModel.Amount,
                    Type = addSavingViewModel.Type
                   // TotalSaved = addSavingViewModel.TotalSaved,
                    //Goal = addSavingViewModel.Goal
                };

                context.Savings.Add(newSaving);
                context.SaveChanges();

                return Redirect("/Saving/Index");
            }

            return View(addSavingViewModel);
        }



        public IActionResult RemoveSaving()
        {
            ViewBag.title = "Remove Saving";
            ViewBag.savings = context.Savings.ToList();
            return View();
        }



        [HttpPost]
        public IActionResult RemoveSaving(int[] savingIds)
        {
            foreach (int savingId in savingIds)
            {
                Saving theSaving = context.Savings.Single(s => s.SavingID == savingId);
            }

            return Redirect("/Saving");
        }
    }
}

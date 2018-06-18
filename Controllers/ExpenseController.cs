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
    public class ExpenseController : Controller
    {

        private BudgetAppDbContext context;

        public ExpenseController(BudgetAppDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Expense> expenses = context.Expenses.ToList();

            return View(expenses);
        }



      /*  [HttpGet]
        public IActionResult Expense()
        {
            List<Expense> expenses = ExpenseData.GetAll();

            return View(expenses);
        }
        */



        public IActionResult AddExpense()
        {
            AddExpenseViewModel addExpenseViewModel = new AddExpenseViewModel();
            return View(addExpenseViewModel);
        }



        [HttpPost]
        public IActionResult AddExpense(AddExpenseViewModel addExpenseViewModel)
        {
            if (ModelState.IsValid)
            {
                Expense newExpense = new Expense
                {
                    Name = addExpenseViewModel.Name,
                    Amount = addExpenseViewModel.Amount,
                    Type = addExpenseViewModel.Type
                    //Balance = addExpenseViewModel.Balance,
                    //Percent = addExpenseViewModel.Percent
                };

                context.Expenses.Add(newExpense);
                context.SaveChanges();

                return Redirect("/Expense/Index");
            }

            return View(addExpenseViewModel);
        }



        public IActionResult RemoveExpense()
        {
            ViewBag.title = "Remove Expense";
            ViewBag.expenses = context.Expenses.ToList();
            return View();
        }



        [HttpPost]
        public IActionResult RemoveExpense(int[] expenseIds)
        {
            foreach (int expenseId in expenseIds)
            {
                Expense theExpense = context.Expenses.Single(x => x.ExpenseID == expenseId);
                context.Expenses.Remove(theExpense);
            }

            context.SaveChanges();

            return Redirect("/Expense/Index");
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class ExpenseData
    {
        static private List<Expense> expenses = new List<Expense>();

        public static List<Expense> GetAll()
        {
            return expenses;
        }

        public static void Add(Expense newExpense)
        {
            expenses.Add(newExpense);
        }

        public static void RemoveExpense(int id)
        {
            Expense expenseToRemove = GetById(id);
            expenses.Remove(expenseToRemove);
        }

        public static Expense GetById(int id)
        {
            return expenses.Single(x => x.ExpenseId == id);
        }
    }
}*/

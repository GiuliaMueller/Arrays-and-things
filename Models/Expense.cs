using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class Expense
    {
        public string Name { get; set; }
        public string Amount { get; set; }
       // public string Balance { get; set; }
       // public string Percent { get; set; }
        public ExpenseType Type { get; set; }

        public int ExpenseID { get; set; }
    }
}

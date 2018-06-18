using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class Income
    {
        public string Name { get; set;}
        public string Amount { get; set; }
        public IncomeType Type { get; set; }
        //public IncomeFrequency Frequency { get; set; }
        public int IncomeID { get; set; }
    }
}

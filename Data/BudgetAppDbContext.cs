using BudgetApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Data
{
    public class BudgetAppDbContext : DbContext
    {
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Saving> Savings { get; set;}
        public DbSet<User> Users { get; set; }
        

        public BudgetAppDbContext(DbContextOptions<BudgetAppDbContext> options)
            : base (options)
        { }

        /*public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options)
            : base(options)
        { }*/
    }
}

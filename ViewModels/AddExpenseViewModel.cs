using BudgetApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.ViewModels
{
    public class AddExpenseViewModel
    {
        [Required(ErrorMessage = "Please enter a name for each new Expense")]
        [Display(Name = "Expense")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a dollar and cent amount")]
        [Range(0, 999999.99)]
        public string Amount { get; set; }

        //[Required(ErrorMessage = "Please enter a dollar and cent amount")]
       /* [Range(0, 999999.99)]
        public string Balance { get; set; }

        [Range(0, 999999.99)]
        public string Percent { get; set; }*/

        public ExpenseType Type { get; set; }

        public List<SelectListItem> ExpenseTypes { get; set; }

        public AddExpenseViewModel()
        {
            ExpenseTypes = new List<SelectListItem>();

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Cable).ToString(),
                Text = ExpenseType.Cable.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.CarInsurance).ToString(),
                Text = ExpenseType.CarInsurance.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.CarMaintenance).ToString(),
                Text = ExpenseType.CarMaintenance.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.CarPayment).ToString(),
                Text = ExpenseType.CarPayment.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Charity).ToString(),
                Text = ExpenseType.Charity.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.ChildCare).ToString(),
                Text = ExpenseType.ChildCare.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Clothing).ToString(),
                Text = ExpenseType.Clothing.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.CreditCard).ToString(),
                Text = ExpenseType.CreditCard.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.DiningOut).ToString(),
                Text = ExpenseType.DiningOut.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Electric).ToString(),
                Text = ExpenseType.Electric.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Entertainment).ToString(),
                Text = ExpenseType.Entertainment.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Garbage).ToString(),
                Text = ExpenseType.Garbage.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Gas).ToString(),
                Text = ExpenseType.Gas.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Groceries).ToString(),
                Text = ExpenseType.Groceries.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.GymMembership).ToString(),
                Text = ExpenseType.GymMembership.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.HealthInsurance).ToString(),
                Text = ExpenseType.HealthInsurance.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.HOA).ToString(),
                Text = ExpenseType.HOA.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.HomeInsurance).ToString(),
                Text = ExpenseType.HomeInsurance.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.LifeInsurance).ToString(),
                Text = ExpenseType.LifeInsurance.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Medical).ToString(),
                Text = ExpenseType.Medical.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Mortgage).ToString(),
                Text = ExpenseType.Mortgage.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Phone).ToString(),
                Text = ExpenseType.Phone.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Prescriptions).ToString(),
                Text = ExpenseType.Prescriptions.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.PropertyTax).ToString(),
                Text = ExpenseType.PropertyTax.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Rent).ToString(),
                Text = ExpenseType.Rent.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.SchoolSupplies).ToString(),
                Text = ExpenseType.SchoolSupplies.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Sewer).ToString(),
                Text = ExpenseType.Sewer.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Tuituion).ToString(),
                Text = ExpenseType.Tuituion.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.Water).ToString(),
                Text = ExpenseType.Water.ToString()
            });

            ExpenseTypes.Add(new SelectListItem
            {
                Value = ((int)ExpenseType.WiFi).ToString(),
                Text = ExpenseType.WiFi.ToString()
            });
        }
    }
}

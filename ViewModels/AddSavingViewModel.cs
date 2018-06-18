using BudgetApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.ViewModels
{
    public class AddSavingViewModel
    {
        [Required(ErrorMessage = "Please enter a name for each new Savings Goal")]
        [Display(Name = "Savings Goal")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a value with dollar and cent amounts")]
        [Range(0, 999999.99)]
        public string Amount { get; set; }

        /*[Required(ErrorMessage = "Please enter a value with dollar and cent amounts")]
        [Range(0, 999999.99)]
        public string TotalSaved { get; set; }

        //[Required(ErrorMessage = "Please enter a value with dollar and cent amounts")]
        [Range(0, 999999.99)]
        public string Goal { get; set; }*/
        
        public SavingType Type { get; set; }

        public List<SelectListItem> SavingTypes { get; set; }

        public AddSavingViewModel()
        {
            SavingTypes = new List<SelectListItem>();

            SavingTypes.Add(new SelectListItem
            {
                Value = ((int)SavingType.Car).ToString(),
                Text = SavingType.Car.ToString()
            });

            SavingTypes.Add(new SelectListItem
            {
                Value = ((int)SavingType.College).ToString(),
                Text = SavingType.College.ToString()
            });

            SavingTypes.Add(new SelectListItem
            {
                Value = ((int)SavingType.Holiday).ToString(),
                Text = SavingType.Holiday.ToString()
            });

            SavingTypes.Add(new SelectListItem
            {
                Value = ((int)SavingType.Home).ToString(),
                Text = SavingType.Home.ToString()
            });

            SavingTypes.Add(new SelectListItem
            {
                Value = ((int)SavingType.Retirement).ToString(),
                Text = SavingType.Retirement.ToString()
            });

            SavingTypes.Add(new SelectListItem
            {
                Value = ((int)SavingType.Travel).ToString(),
                Text = SavingType.Travel.ToString()
            });

            SavingTypes.Add(new SelectListItem
            {
                Value = ((int)SavingType.Vacation).ToString(),
                Text = SavingType.Vacation.ToString()
            });

        }
    }
} 


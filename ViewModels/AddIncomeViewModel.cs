using BudgetApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.ViewModels
{
    public class AddIncomeViewModel
    {
        [Required(ErrorMessage = "Please enter a name for each new Income")]
        [Display(Name = "Income")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a dollar and cent amount")]
        [Range(0, 999999.99)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public string Amount { get; set; }
        

        public IncomeType Type { get; set; }

        public List<SelectListItem> IncomeTypes { get; set; }

        public AddIncomeViewModel()
        {
            IncomeTypes = new List<SelectListItem>();

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.Alimony).ToString(),
                Text = IncomeType.Alimony.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.CapitalGains).ToString(),
                Text = IncomeType.CapitalGains.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.ChildSupport).ToString(),
                Text = IncomeType.ChildSupport.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.Investment).ToString(),
                Text = IncomeType.Investment.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                
                Value = ((int)IncomeType.JuryDuty).ToString(),
                Text = IncomeType.JuryDuty.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.Lottery).ToString(),
                Text = IncomeType.Lottery.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.Paycheck).ToString(),
                Text = IncomeType.Paycheck.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.RentalIncome).ToString(),
                Text = IncomeType.RentalIncome.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.Retirement).ToString(),
                Text = IncomeType.Retirement.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.SocialSecurity).ToString(),
                Text = IncomeType.SocialSecurity.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.SocialSecurityDisability).ToString(),
                Text = IncomeType.SocialSecurityDisability.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.Tips).ToString(),
                Text = IncomeType.Tips.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.Unemployment).ToString(),
                Text = IncomeType.Unemployment.ToString()
            });

            IncomeTypes.Add(new SelectListItem
            {
                Value = ((int)IncomeType.VeteranDisability).ToString(),
                Text = IncomeType.VeteranDisability.ToString()
            });

            /*foreach (var Type in SelectList)
            {
                switch (Type)
                {
                    case IncomeType.Alimony:
                        break;
                    case IncomeType.CapitalGains:("Capital Gains");
                        break;
                    case IncomeType.ChildSupport:("Child Support");
                        break;
                    case IncomeType.Investment:
                        break;
                    case IncomeType.JuryDuty:
                        break;
                    case IncomeType.Lottery:
                        break;
                    case IncomeType.Paycheck:
                        break;
                    case IncomeType.Retirement:
                        break;
                    case IncomeType.RentalIncome:("Rental Income")
                        break;
                    case IncomeType.SocialSecurity: ("Social Security")
                        break;
                    case IncomeType.SocialSecurityDisability:("Social Security Disability")
                        break;
                    case IncomeType.Tips:
                        break;
                    case IncomeType.Unemployment:
                        break;
                    case IncomeType.VeteranDisability:("Veteran Disability")
                        break;
                    default:
                        break;
                }*/



        }
    }
}

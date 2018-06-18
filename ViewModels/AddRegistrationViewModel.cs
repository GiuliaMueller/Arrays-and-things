using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.ViewModels
{
    public class AddRegistrationViewModel
    {
        [Required(ErrorMessage = "Valid email address is required for logging in")]
        [EmailAddress]
        public string LogInName { get; set; }

        [Required(ErrorMessage = "Valid password is required")]

        //[Compare(Password1 == Password2]
        public string Password1 { get; set; }

        //[Required]
       // public string Password2 { get; set; }

    }
}

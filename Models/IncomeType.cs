using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public enum IncomeType
    {
        Alimony,
        [Description("Capital Gains")]
        CapitalGains,
        [Description("Child Support")]
        ChildSupport,
        Investment,
        JuryDuty,
        Lottery,
        Paycheck,
        Retirement,
        RentalIncome,
        [Description("Social Security")]
        SocialSecurity,
        [Description("Social Security Disability")]
        SocialSecurityDisability,
        Tips,
        Unemployment,
        VeteranDisability
    }
}

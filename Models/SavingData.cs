/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class SavingData
    {
        static private List<Saving> savings = new List<Saving>();

        public static List<Saving> GetAll()
        {
            return savings;
        }

        public static void Add(Saving newSaving)
        {
            savings.Add(newSaving);
        }

        public static void Remove(int id)
        {
            Saving savingToRemove = GetById(id);
            savings.Remove(savingToRemove);
        }

        public static Saving GetById(int id)
        {
            return savings.Single(x => x.SavingId == id);
        }
    }
}*/

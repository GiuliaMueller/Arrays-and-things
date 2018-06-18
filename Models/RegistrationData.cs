/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class RegistrationData
    {
        static private List<Registration> registrations = new List<Registration>();

        public static List<Registration> GetAll()
        {
            return registrations;
        }

        public static void Add(Registration newRegistration)
        {
            registrations.Add(newRegistration);
        }

        public static void Remove(int id)
        {
            Registration registrationToRemove = GetById(id);
            registrations.Remove(registrationToRemove);
        }

        public static Registration GetById(int id)
        {
            return registrations.Single(x => x.RegistrationID == id);
        }
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class UserData
    {
        static private List<User> logIns = new List<User>();

        public static List<User> GetAll()
        {
            return logIns;
        }

        public static void Add(User newLogIn)
        {
            logIns.Add(newLogIn);
        }

        public static void Remove(int id)
        {
            User logInToRemove = GetById(id);
            logIns.Remove(logInToRemove);
        }

        public static User GetById(int id)
        {
            return logIns.Single(x => x.LogInID == id);
        }
    }
}*/

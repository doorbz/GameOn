using System;
using System.Linq;
using GameOn.DataLayer;
using GameOn.DataLayer.Managers;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUsers();
        }

        private static void GetUsers()
        {
            var users = new UserManager();
            foreach (var user in users.GetList())
            {
                Console.WriteLine(user.FirstName);
            }
        }
    }
}

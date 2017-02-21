using System;
using System.Linq;
using GameOn.DataLayer;

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
            using (var context = new GameOnContext())
            {
                var users = context.Users.ToList();
                foreach (var user in users)
                {
                    Console.WriteLine(user.FirstName);
                }
            }
        }
    }
}

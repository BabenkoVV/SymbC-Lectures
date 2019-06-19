using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_UserListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    "Start sign in form.\n");
                User user = new User();

                Console.Write("Enter user name:");
                user.Name = Console.ReadLine();
                Console.Write("Enter user password:");
                user.Password = Console.ReadLine();
                Console.Write("Enter user email:");
                user.Email = Console.ReadLine();

                user.ValidateUser();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace HW6_UserListApp
{
    class User: IUser, IValidator
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public static List<User> UsersList { get; set; } = new List<User>{
                new User("Alisson", "Becker", "AlBecker@LFC.com"),
                new User("Roberto", "Firmino", "RobFirmino@LFC.com"),
                new User("Mohamed", "Salah", "MoSalah@LFC.com"),
                new User("Virgil", "van Dijk", "VVD@LFC.com") };

        public User()
        {

        }

        public User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }

        public string GetFullInfo()
        {
            return $"User info:\n Name: '{Name}'; Password: '{Password}'; Email: '{Email}'.";
        }

        public void ValidateUser()
        {
            if(this.Name.Equals("exit") && this.Password.Equals("exit") && this.Email.Equals("exit"))
            {
                Console.WriteLine("\nProgram exit.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }

            Console.WriteLine($"\nStart validating user '{this.Name}'.");

            if(UsersList.Count(us => (us.Name.Equals(this.Name))&&(us.Password.Equals(this.Password)))!=0)
            {
                Console.WriteLine($"User '{this.Name}' was found in the database. {this.GetFullInfo()}");
            }
            else
            {
                Console.WriteLine($"User '{this.Name}' was not found in the database. Adding user to database");
                UsersList.Add(new User(this.Name, this.Password, this.Email));
            }
        }



    }
}

using System;

namespace HW4_ValueRef
{
    class Program
    {
        static void Main(string[] args)
        {
            User mainUser = new User();
            Console.WriteLine("Main user at start:");
            mainUser.PrintUser();

            User cloneUser = mainUser.CloneUser();
            //User cloneUser = (User)mainUser.CloneUser();
            Console.WriteLine("Clone user at start:");
            cloneUser.PrintUser();

            cloneUser.Age = 18;
            cloneUser.SomeMoney = 35000;
            cloneUser.FirstName = "Jotaro";
            cloneUser.LastName = "Kujo";
            cloneUser.LazyFlag = false;

            Console.WriteLine("Main user after changes:");
            mainUser.PrintUser();
            Console.WriteLine("Clone user after changes:");
            cloneUser.PrintUser();
        }
    }
}

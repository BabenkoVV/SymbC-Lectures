using System;

namespace HW4_ValueRef
{
    public class User
    {
        public User()
        {
            Age = 25;
            FirstName = "Jonathan";
            LastName = "Joestar";
            SomeMoney = 54321;
            LazyFlag = true;
        }

        public User(int age, string firstName, string lastName, long someMoney, bool lazyFlag)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            SomeMoney = someMoney;
            LazyFlag = lazyFlag;
        }

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long SomeMoney { get; set; }
        public bool LazyFlag { get; set; }

        public void PrintUser()
        {
            Console.WriteLine($"User age: '{Age}'; \n " +
                $"First Name: '{FirstName}'; \n " +
                $"Last Name: '{LastName}'; \n " +
                $"Money amount: '{SomeMoney}'; \n " +
                $"Lazy flag value: '{LazyFlag}'; \n" +
                $"-----------------------------------");
        }
        public User CloneUser()
        {
            return new User { Age = this.Age, FirstName = this.FirstName, LastName = this.LastName, SomeMoney = this.SomeMoney, LazyFlag = this.LazyFlag };
        }

        //public object CloneUser()
        //{
        //    return this.MemberwiseClone();
        //}

    }
}

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string FirstName;
            string Lastname;
            Console.WriteLine("Whats is your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            Lastname = Console.ReadLine();
          
            Console.WriteLine($"Hello, {FirstName} {Lastname}");
            Console.WriteLine("How old are you?");
            string UserInput;
            UserInput = Console.ReadLine();
            int Year;
            Year = Int32.Parse(UserInput);
            int Age = 2020 - Year;
            Console.WriteLine("You are born in " + Age );
        }
    }
}

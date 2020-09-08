using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Console.WriteLine("Whats your name?");
            string FirstName;
            string Lastname;
            Console.WriteLine("Whats is your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            Lastname = Console.ReadLine();
            //Console.WriteLine("Hello, " + FirstName + " " + Lastname);
            Console.WriteLine($"Hello, {FirstName} {Lastname}");
            
        }
    }
}

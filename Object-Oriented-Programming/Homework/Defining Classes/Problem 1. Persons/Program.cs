using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Persons
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Dou you have an email? Anwser wit yes or no");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("What is your email?");
                string email = Console.ReadLine();
                try
                {
                    Person person = new Person(name, age, email);
                    Console.WriteLine(person);
                }
                catch (ArgumentException)
                { 
                    Console.WriteLine("You have entered an invalid arugemnts");
                }
            }
            else
            {
                try
                {
                    Person person = new Person(name, age);
                    Console.WriteLine(person);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("You have entered an invalid arguments");
                }
            }
        }
    }
}

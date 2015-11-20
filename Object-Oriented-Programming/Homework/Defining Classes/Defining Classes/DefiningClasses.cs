using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ime na kucheto: ");
            string dogName = Console.ReadLine();
            Console.Write("Poroda na kucheto: ");
            string dogBreed = Console.ReadLine();

            Dog unnamed = new Dog();
            Dog sharo = new Dog("Sharo", null);

            unnamed.Name = dogName;
            unnamed.Breed = dogBreed;

            unnamed.Bark();
            sharo.Bark();
        }
    }
}

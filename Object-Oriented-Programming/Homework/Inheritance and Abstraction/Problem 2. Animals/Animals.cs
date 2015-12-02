using System;
using System.Linq;

namespace Problem_2.Animals
{
    class Animals
    {
        static void Main()
        {
            Animal[] animals = new Animal[4];
            animals[0] = new Cat("Tom", 10, "Mujko");
            animals[1] = new Dog("Sparky", 5, "Mujko");
            animals[2] = new Frog("Gufi", 3, "Mujko");
            animals[3] = new Kitten("Liza", 6, "Jensko");

            double averageAge = animals.Average(animal => animal.Age);

            Console.WriteLine(averageAge);
        }
    }
}

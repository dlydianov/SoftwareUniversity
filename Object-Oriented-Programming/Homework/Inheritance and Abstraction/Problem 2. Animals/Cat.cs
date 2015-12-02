using System;
using Problem_2.Animals.Interfaces;

namespace Problem_2.Animals
{
    class Cat : Animal, ISoundProducible
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Mqu...");
        }
    }
}

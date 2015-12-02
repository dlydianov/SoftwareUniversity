using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_2.Animals.Interfaces;

namespace Problem_2.Animals
{
    class Frog : Animal, ISoundProducible
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Kvakk..");
        }
    }
}

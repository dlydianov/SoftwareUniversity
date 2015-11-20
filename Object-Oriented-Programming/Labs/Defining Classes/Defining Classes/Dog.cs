using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class Dog
    {
        public Dog() : this(null, null)
        {
        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
            //TODO: initialize properties
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine(
                "{0} ({1}) said: Bauuuuuu!",
                this.Name ?? "neznaina poroda",
                this.Breed ?? "neznaina poroda");
        }
    }
}

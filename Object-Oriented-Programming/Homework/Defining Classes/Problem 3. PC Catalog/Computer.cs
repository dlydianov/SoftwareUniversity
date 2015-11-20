using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.PC_Catalog
{
    class Computer
    {
        private string name;
        private decimal price;
        private List<Component> components;

        public Computer(string name, List<Component> components)
        {
            this.name = name;
            this.components = components;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get { return components.Sum(price => price.Price); }
        }

        public override string ToString()
        {
            string computer = string.Format("Name: {0}\nComponents: {1}\nPrice: {2}", name, string.Join("\n", components), price);
            return computer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.PC_Catalog
{
    class Component
    {
        private string name;
        private decimal price;
        private string details;

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, decimal price, string details)
            : this(name, price)
        {
            this.Details = details;
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
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.price = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException();
                }
                this.details = value;
            }
        }

        public override string ToString()
        {
            string componentToString = "";
            if (details != string.Empty || details != null)
            {
                componentToString = string.Format("name: {0}, details: {1}, price: {2:C}", name, details, price);
            }
            else
            {
                componentToString = string.Format("name: {0}, price: {1:C}", name, price);
            }
            return componentToString;
        }
    }
}

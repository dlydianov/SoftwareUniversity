using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Laptop_Shop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string proccesor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double price;

        public Laptop(string Model, double Price)
        {
            this.Model = Model;
            this.Price = Price;
        }

        public Laptop(string model, string manufacturer, string proccesor, int ram, string graphicCard,
            string hdd = null, string screen = null, Battery battery = null, double price = 0)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Proccesor = proccesor;
            this.Ram = ram;
            this.GraphicsCard = graphicCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.battery = battery;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                this.manufacturer = value;
            }
        }

        public string Proccesor
        {
            get { return this.proccesor; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                this.proccesor = value;
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                this.graphicsCard = value;
            }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                this.screen = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <0)
                {
                    throw new ArgumentException();
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("model: {0}\n", model));
            if (manufacturer != null)
            {
                result.Append(string.Format("manufacturer: {0}\n", manufacturer));
            }
            if (proccesor != null)
            {
                result.Append(string.Format("processor: {0}\n", proccesor));
            }
            if (ram != 0)
            {
                result.Append(string.Format("RAM: {0} GB\n", ram));
            }
            if (graphicsCard != null)
            {
                result.Append(string.Format("graphics card: {0}\n", graphicsCard));
            }
            if (hdd != null)
            {
                result.Append(string.Format("HDD: {0}\n", hdd));
            }
            if (screen != null)
            {
                result.Append(string.Format("screen: {0}\n", screen));
            }
            if (battery != null)
            {
                result.Append(battery);
            }
            if (price != 0)
            {
                result.Append(string.Format("price: {0:F2} lv.", price));
            }


            return result.ToString();

        }
    }
}

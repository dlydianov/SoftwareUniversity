using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Laptop_Shop
{
    class Battery
    {
        private string battery;
        private double batteryLife;

        public Battery(string battery, double batteryLife)
        {
            this.BatteryType = battery;
            this.BatteryLife = batteryLife;
        }

        public string BatteryType
        {
            get { return this.battery; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                this.battery = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return string.Format("battery: {0}\nbattery life: {1} hours\n", battery, batteryLife);
        }
    }
}

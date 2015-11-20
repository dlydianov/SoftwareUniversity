using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Laptop_Shop
{
    class Program
    {
        static void Main()
        {
            var firstLaptop = new Laptop("Lenovo yoga 2 pro", 541.2531);
            var asd = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "intel", 4, "nvidia", "ssd", "ips", new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5), 4000);

            Console.WriteLine(firstLaptop);
        }
    }
}

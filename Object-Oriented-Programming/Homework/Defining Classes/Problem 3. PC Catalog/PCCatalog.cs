using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.PC_Catalog
{
    class PCCatalog
    {
        static void Main()
        {
            var firstComputer = new Computer("Acer", new List<Component>
            {
                new Component("HDD", 250, "256GB SSD"),
                new Component("Screen", 500, "IPS FullHD")
            });
            Console.WriteLine(firstComputer);
        }
    }
}

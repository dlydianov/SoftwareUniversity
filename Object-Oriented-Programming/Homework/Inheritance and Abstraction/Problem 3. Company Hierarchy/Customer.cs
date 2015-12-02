using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
    class Customer : Person, Interfaces.ICustomer
    {
        private double netPurchaseAmount;
        public Customer(string name, string lastName, string id, double netPurchaseAmount)
            : base(name, lastName, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public double NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                this.netPurchaseAmount = value;
            }
        }
    }
}

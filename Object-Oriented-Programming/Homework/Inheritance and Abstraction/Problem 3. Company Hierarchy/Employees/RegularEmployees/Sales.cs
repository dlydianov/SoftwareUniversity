using System;

namespace Problem_3.Company_Hierarchy.Employees.RegularEmployees
{
    public class Sales
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sales(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Date = DateTime.Now;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Product name cannot be null.");
                }
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            private set { this.date = value; }
        }

        public decimal Price 
        {
            get { return this.price; }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Product Name: {0}\nDate: {1}\nPrice: {2}\n", ProductName, Date, Price);
        }
    }
}
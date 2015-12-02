using System;

namespace Problem_1.Human__Student_and_Worker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot be negative.");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result = (WeekSalary/7)/WorkHoursPerDay;
            return result;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} LastName: {1} MoneyPerHour: {2:F2}", firstName.PadRight(10, ' '), lastName.PadRight(14, ' '),
                MoneyPerHour());
        }
    }

}

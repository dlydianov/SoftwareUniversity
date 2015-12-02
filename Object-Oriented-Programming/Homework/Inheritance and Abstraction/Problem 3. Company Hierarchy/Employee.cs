using System;
using Problem_3.Company_Hierarchy.Enumerator;

namespace Problem_3.Company_Hierarchy
{
    public class Employee : Person, Interfaces.IEmployee
    {
        private decimal salary;
        private Department department;
        public Employee(string name, string lastName, string id, decimal salary, Department department)
            : base(name, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }
        public override string ToString()
        {
            return base.ToString() + string.Format("The Employee is a: {2}\nSalary: {0:F2}\nDepartment: {1}\n", this.Salary, this.Department, this.GetType().Name);
        }
    }
}

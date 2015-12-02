using System;
using System.Collections.Generic;
using System.Linq;
using Problem_3.Company_Hierarchy.Enumerator;
using Problem_3.Company_Hierarchy.Interfaces;

namespace Problem_3.Company_Hierarchy.Employees.RegularEmployees
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private HashSet<Sales> salesOfEmployee;

        public SalesEmployee(string name, string lastName, string id, decimal salary, Department department, HashSet<Sales> salesEmployee )
            : base(name, lastName, id, salary, department)
        {
            this.SalesOfEmployee = salesEmployee;
        }
        public HashSet<Sales> SalesOfEmployee { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("Sales: {0}\n", string.Join(", ", SalesOfEmployee.Select(x => x.ProductName)));
        }
    }
}

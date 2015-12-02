using System;
using System.Collections.Generic;
using System.Linq;
using Problem_3.Company_Hierarchy.Enumerator;

namespace Problem_3.Company_Hierarchy.Employees
{
    public class Manager : Employee, Interfaces.IManager
    {
        private HashSet<Employee> employees;
        public Manager(string name, string lastName, string id, decimal salary, Department department, HashSet<Employee> employees)
            : base(name, lastName, id, salary, department)
        {
            this.Employees = employees;
        }

        public HashSet<Employee> Employees
        {
            get { return this.employees; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Employees field cannot be null.");
                }
                this.employees = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Managed employees: {0}\n", string.Join(", ", employees.Select(x => x.Name + " " + x.LastName)));
        }
    }
}

using System;
using Problem_3.Company_Hierarchy.Enumerator;

namespace Problem_3.Company_Hierarchy.Employees
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee(string name, string lastName, string id, decimal salary, Department department)
            : base(name, lastName, id, salary, department)
        {
        }
    }
}

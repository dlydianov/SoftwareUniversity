using System;
using System.Collections.Generic;
using System.Linq;
using Problem_3.Company_Hierarchy.Enumerator;
using Problem_3.Company_Hierarchy.Interfaces;

namespace Problem_3.Company_Hierarchy.Employees.RegularEmployees
{
    public class Developer : Employee, IDeveloper
    {
        private HashSet<Projects> projectsOfTheDeveloper;

        public Developer(string firstName, string lastName, string id, decimal salary, Department department, HashSet<Projects> projectsOfTheDeveloper) 
            : base(firstName, lastName, id, salary, department)
        {
            this.ProjectsOfTheDeveloper = projectsOfTheDeveloper;
        }

        public HashSet<Projects> ProjectsOfTheDeveloper { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                   string.Format("Projects Of The Developer: {0}\n",
                       string.Join(", ", ProjectsOfTheDeveloper.Select(x => x.ProjectName)));
        }
    }
}

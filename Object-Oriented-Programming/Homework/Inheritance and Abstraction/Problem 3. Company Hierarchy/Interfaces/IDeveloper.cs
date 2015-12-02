using System.Collections.Generic;
using Problem_3.Company_Hierarchy.Employees.RegularEmployees;

namespace Problem_3.Company_Hierarchy.Interfaces
{
    public interface IDeveloper
    {
        HashSet<Projects> ProjectsOfTheDeveloper { get; set; }
    }
}
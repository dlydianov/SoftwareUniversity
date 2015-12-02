using System.Collections.Generic;

namespace Problem_3.Company_Hierarchy.Interfaces
{
    public interface IManager
    {
        HashSet<Employee> Employees { get; set; }
    }
}
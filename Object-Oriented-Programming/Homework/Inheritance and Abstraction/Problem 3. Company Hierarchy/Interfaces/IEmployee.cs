using Problem_3.Company_Hierarchy.Enumerator;

namespace Problem_3.Company_Hierarchy.Interfaces
{
    public interface IEmployee
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
    }
}
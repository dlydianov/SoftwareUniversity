using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.Company_Hierarchy.Employees;
using Problem_3.Company_Hierarchy.Employees.RegularEmployees;
using Problem_3.Company_Hierarchy.Enumerator;
using Problem_3.Company_Hierarchy.Interfaces;

namespace Problem_3.Company_Hierarchy
{
    class CompanyHierarchy
    {
        static List<IEmployee> Employees()
        {
            Projects homeAlone = new Projects("Home alone", new DateTime(2016, 05, 22), "");
            Projects tarzan = new Projects("Tarzan", new DateTime(2015, 05, 22), "The movie is being shot right now");
            HashSet<Projects> projects = new HashSet<Projects>() { homeAlone, tarzan };

            Sales krastavica = new Sales("krastavici", 1.15m);
            Sales korniz = new Sales("Korniz", 22.15m);
            Sales boiler = new Sales("Boiler", 200.05m);
            HashSet<Sales> sales = new HashSet<Sales>() { krastavica, korniz, boiler };

            SalesEmployee salesEmployee = new SalesEmployee("Daniel", "Lydianov", "9304294003", 2500.00m,
                Department.Production, sales);
            Developer developer = new Developer("Angel", "Miladinov", "9304294003", 1500.00m,
                Department.Production, projects);

            HashSet<Employee> managedEmployees = new HashSet<Employee>() { salesEmployee, developer };
            Manager manager = new Manager("Volen", "Siderov", "9304294003", 2000.00m, Department.Sales, 
                managedEmployees);

            List<IEmployee> employees = new List<IEmployee>() { salesEmployee, developer, manager };
            return employees;
        }
        private static void PrintOutput(List<IEmployee> employees)
        {
            foreach (var employee in employees)
            {
                Console.Write(employee);
                LineForNewEmployee();
            }
        }
        static void LineForNewEmployee()
        {
            Console.WriteLine("-----------------------------------------");
        }
        static void Main()
        {
            try
            {
                List<IEmployee> employees = Employees();
                PrintOutput(employees);
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

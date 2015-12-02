using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1.Human__Student_and_Worker
{
    public class Human_Student_and_Worker
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Cvetomir", "Georgiev", 1),
                new Student("Martin", "Ahimedov", 9),
                new Student("Meri", "Koliova", 8),
                new Student("Dimana", "Dimitrova", 7),
                new Student("Ico", "Karaivanov", 6),
                new Student("Barak", "Obama", 10)
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Alah", "Akbar", 90, 8),
                new Worker("Batman", "Jokera", 155, 8),
                new Worker("Marko", "Menimehmedov", 160, 8),
                new Worker("Zarko", "Mohamed", 95, 8),
                new Worker("Osama", "Binladen", 70, 8)
            };

            var orderedStudents = students.OrderBy(x => x.facultyNumber).ToList();
            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            var resultList =
                orderedStudents.Concat(orderedWorkers.Cast<Human>())
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.LastName)
                    .ToList();

            Console.WriteLine();
            Console.WriteLine("////STUDENTS////");
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.WriteLine("////WORKERS////");
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();
            Console.WriteLine("///Sichko///");
            Console.WriteLine(string.Join("\n", resultList));
        }
    }
    
}

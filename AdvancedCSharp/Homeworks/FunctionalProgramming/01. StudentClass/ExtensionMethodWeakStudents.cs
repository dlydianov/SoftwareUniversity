using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public static class ExtensionMethodWeakStudents
{
    public static void WeakMarks(this List<Students> students)
       {
           Console.WriteLine("Students who have excactly two marks 2: ");
           students
               .Where(student => student.marks.Count(mark => mark == 2) == 2)
               .Select(student => new { FullName = student.firstName + " " + student.lastName, Marks = student.marks })
               .ToList()
               .ForEach(student => Console.WriteLine(student.FullName));

              
               
                 
       }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


public static class StudentClass
{
    static void LineBetweenProblems()
    {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
    }
    static List<Students> StudentGenerator()
    {
        // PROBLEM 1:
        // Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. Create a List<Student> with sample students. These students will be used for the next few tasks. 
        return new List<Students>()
        {
             new Students {firstName = "Ivan", lastName ="Yordanov", age = 22, email="danchooo@gmail.com", facultyNumber = "289114", phoneNumber = "0279-43-93-23", groupNumber=2,groupName = "Weak", marks = new List<int>() {5, 4, 6, 3, 2, 2, 3}}, 
         new Students {firstName = "Evlogi", lastName ="Hristov", age = 24, email="evlogi@abv.bg", facultyNumber = "261214", phoneNumber = "0889-53-53-19", groupNumber=2, marks = new List<int>() {6, 4, 6, 4, 2, 2, 2} ,groupName = "Weak"},
         new Students {firstName = "Zornica", lastName ="Georgieva", age = 19, email="zori@gmail.com", facultyNumber = "924144", phoneNumber = "+3592 89-91-52-42", groupNumber=25, marks = new List<int>(){3, 4, 3, 3, 2,4, 5},groupName = "Medium"},
             new Students {firstName = "Georgi", lastName ="Ivanov", age = 21, email="georgi@abv.bg", facultyNumber = "421954", phoneNumber = "+359 289-53-50 -55", groupNumber=7, marks = new List<int>() {6, 5, 6, 3, 2 ,2, 3},groupName = "Medium"},
                 new Students {firstName = "Diana", lastName ="Vasileva", age = 21, email="diana_vasileva94@abv.bg", facultyNumber = "421914", phoneNumber = "0886-91-36-66", groupNumber=2, marks = new List<int>() {6, 6, 6, 6, 6, 6, 6},groupName = "Excellent"}
        };
    }
    static List<Specialties> Specialties()
    {
        return new List<Specialties>()
        {
            new Specialties{ specialtyName = "Web Developer", facultyNumber = "289114"},
             new Specialties{ specialtyName = "Web Developer", facultyNumber = "421914"},
              new Specialties{ specialtyName = "Web Developer", facultyNumber = "421954"},
               new Specialties{ specialtyName = "QA Engineer", facultyNumber = "421914"},
               new Specialties{ specialtyName = "QA Engineer", facultyNumber = "261214"},
               new Specialties{ specialtyName = "PHP Developer", facultyNumber = "924144"},
               new Specialties{ specialtyName = "PHP Developer", facultyNumber = "289114"},
        };
    }
    static void PrintingFirstAndLastName(IEnumerable<Students> students, string typeOfQuery)
    {
        Console.WriteLine(typeOfQuery);
        foreach (var student in students)
        {
            Console.WriteLine(student.firstName + " " + student.lastName);
        }
        LineBetweenProblems();

    }

    static void Main()
    {
        List<Students> students = StudentGenerator();
        // PROBLEM 2 
        // Print all students from group number 2. Use a LINQ query. Order the students by FirstName.

        var groupTwo =
            students
            .Where(group => group.groupNumber == 2)
            .OrderBy(firstname => firstname.firstName);
        PrintingFirstAndLastName(groupTwo, "Students from group Two: ");


        // Problem 3
        // Print all students whose first name is before their last name alphabetically. Use a LINQ query.

        var firstNameBeforeLastNameAlphabetically =
            from student in students
            where student.firstName.First() < student.lastName.First()
            select student;


        PrintingFirstAndLastName(firstNameBeforeLastNameAlphabetically, "Students whose first name is before their last name alphabetically: ");

        // Problem 4
        // Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age.

        Console.WriteLine("All students with age between 18 and 24:");
        students
        .Where(age => age.age <= 24 && age.age >= 18)
        .Select(student => new Students() { firstName = student.firstName, lastName = student.lastName, age = student.age })
        .ToList()
        .ForEach(student => Console.WriteLine(student.firstName + " " + student.lastName + " " + student.age));

        LineBetweenProblems();

        // Problem 5
        // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax.

        var descendingOrderLambda =
            students
            .OrderByDescending(student => student.firstName)
            .ThenByDescending(student => student.lastName);
        PrintingFirstAndLastName(descendingOrderLambda, "Names in descending order with lambda expression: ");


        var descendingOrdeLinq =
            from student in students
            orderby student.firstName, student.lastName descending
            select student;
        PrintingFirstAndLastName(descendingOrdeLinq, "Names in descending order with Linq expression: ");

        // Problem 6
        // Print all students that have email @abv.bg. Use LINQ.

        var abvEmailList =
            from student in students
            where student.email.Contains("@abv.bg")
            select student;

        Console.WriteLine("Students with abv email: ");
        foreach (var student in abvEmailList)
        {
            Console.WriteLine("{0} {1} - {2}", student.firstName, student.lastName, student.email);
        }
        LineBetweenProblems();

        // Problem 7
        // Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.
        var telephoneNumberQuery =
            from student in students
            where student.phoneNumber.StartsWith("02") | student.phoneNumber.StartsWith("+3592") | student.phoneNumber.StartsWith("+359 2")
            select student;

        Console.WriteLine("Students with telephone number starting with 02: ");
        foreach (var student in telephoneNumberQuery)
        {
            Console.WriteLine("{0} {1} - {2}", student.firstName, student.lastName, student.phoneNumber);
        }
        LineBetweenProblems();

        // Problem 8 
        // Print all students that have at least one mark Excellent (6). Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.
        var excellentStudents =
            from student in students
            where student.marks.Contains(6)
            select (new { FullName = student.firstName + " " + student.lastName, Marks = student.marks });
        Console.WriteLine("Students with excellent grade: ");
        foreach (var student in excellentStudents)
        {

            Console.WriteLine(student.FullName);
        }
        LineBetweenProblems();
        // Problem 9
        // Write a similar program to the previous one to extract the students with exactly two marks "2". Use extension methods.

        students.WeakMarks();
        LineBetweenProblems();

        // Problem 10
        // Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).

        Console.WriteLine("Students who enrolled in 2014: ");
        students
        .Where(student => student.facultyNumber.Substring(4, 2) == "14")
        .ToList()
            // .ForEach(student => Console.WriteLine("{0} {1} - marks: {2}, {3}, {4}, {5}, {6}, {7}", student.firstName, student.lastName, student.marks[0], student.marks[1], student.marks[2], student.marks[3], student.marks[4], student.marks[5], student.marks[6]));
        .ForEach(student => Console.WriteLine("{0} {1} - marks: {2}", student.firstName, student.lastName, string.Join(",", student.marks)));

        LineBetweenProblems();
        // Problem 11.
        // Add a GroupName property to Student. Write a program that extracts all students grouped by GroupName and then prints them on the console. Print all group names along with the students in each group. Use the "group by into" LINQ operator.
        var groupNameQuery =
            from student in students
            group student by student.groupName into groups
            orderby groups.Key
            select groups;

        foreach (var group in groupNameQuery)
        {

            Console.Write("{0} - ", group.Key);
            foreach (var student in students)
            {
                if(student.groupName == group.Key)
                {
                    Console.Write(student.firstName + " " + student.lastName + " ");
                }
            }
            Console.WriteLine();
        }
        LineBetweenProblems();

        // Problem 12.
        // Create a class StudentSpecialty that holds specialty name and faculty number. Create a list of student specialties, where each specialty corresponds to a certain student (via the faculty number). Print all student names alphabetically along with their faculty number and specialty name. Use the "join" LINQ operator. Example:

        List<Specialties> specialties = Specialties();

        var specialtiesOfStudents =
            from specialty in specialties
            join student in students on specialty.facultyNumber equals student.facultyNumber
            orderby student.firstName
            select new { Student = student.firstName + " " + student.lastName, FacultyNum = student.facultyNumber, SpecialtyName = specialty.specialtyName };

        Console.WriteLine("{0} {1, 18} {2, 12}", "Name:", "FacNum:", "Specialty:");
        foreach (var student in specialtiesOfStudents)
        {
            Console.WriteLine("{0} - {1, -5} - {2, -15}", student.Student, student.FacultyNum, student.SpecialtyName);
        }
    }
}


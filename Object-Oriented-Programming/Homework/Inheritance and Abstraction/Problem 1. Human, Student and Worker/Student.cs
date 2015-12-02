using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Human__Student_and_Worker
{
    public class Student : Human
    {
        public int facultyNumber;

        public Student(string firstName, string lastName, int facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public int FacultyNumber
        {
            get
            { return this.facultyNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot be empty.");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} LastName: {1} FacultyNumber: {2}", firstName.PadRight(10, ' '), lastName.PadRight(14, ' '), facultyNumber);
        }
    }
}

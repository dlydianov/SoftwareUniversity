using System;

namespace Problem_1.Human__Student_and_Worker
{
    public abstract class Human
    {
        protected string firstName;
        protected string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name Cannot be null");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                this.lastName = value;
            }
        }
    }
}

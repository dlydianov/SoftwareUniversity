using System;

namespace Problem_3.Company_Hierarchy
{
    public class Person : Interfaces.IPerson
    {
        protected string name;
        protected string lastName;
        protected string id;

        public Person(string name, string lastName, string id)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Id = id;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null.");
                }
                this.name = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Lastname cannot be null.");
                }
                this.lastName = value;
            }
        }

        public string Id
        {
            get { return this.id; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("ID cannot be null.");
                }
                this.id = value;
            }
        }
        public override string ToString()
        {
            string result = string.Format("First Name: {0}\nLast Name: {1}\nId: {2}\n", this.Name, this.LastName, this.Id);
            return result;
        }
    }
}

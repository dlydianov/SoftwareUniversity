﻿using System;
using Problem_2.Animals.Interfaces;

namespace Problem_2.Animals
{
    abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be Empty.");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Gender cannot be null.");
                }
                this.gender = value;
            }
        }
    }
}

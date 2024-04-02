using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string name;
        private DateTime birthDate;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        public string Name
        {
            get { return name; }
            // Set value equal to Name if it has at least one character (i.e. name is not blank)
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name must have at least one character.");
                }
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            // Set value equal to birthDate if its after the 1st of January, 1900.
            set
            {
                if (value >= new DateTime(1900, 1, 1))
                {
                    birthDate = value;
                }
                else
                {
                    throw new Exception("Birth date must be on or after the 1st of January 1900.");
                }
            }
        }

        public double Height
        {
            get { return height; }
            // Set value equal to height if height is above 0.
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new Exception("Height must be above 0.");
                }
            }
        }

        public bool IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; }
        }

        public int NoOfChildren
        {
            get { return noOfChildren; }
            // Set value equal to noOfChildren if not less than 0.
            set 
            {
                if (value >= 0)
                {
                    noOfChildren = value;
                }
                else
                {
                    throw new Exception("Number of children cannot be negative.");
                }
            }
        }

        // Constructor
        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
        }

        // Constructor Overload to initialize person objects with zero children.
        public Person(string name, DateTime birthDate, double height, bool isMarried) : this(name, birthDate, height, isMarried, 0)
        {
        }

        // Method that combines all fields of a person object (the values of this. object are implied!) into one string separated by ';'.
        public string MakeTitle()
        {
            return $"{Name};{BirthDate};{Height};{IsMarried};{NoOfChildren}";
        }
    }
}


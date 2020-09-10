using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Person
    {
        // STEPS
        /* 1. Create private variables convention is _age for a private variable called age!
         * 2. Create properties for the variables
         * 3. Create constructor to make fName and lName manadatory
         * 4. Set validation properites in Age FName and LName
         * 5. Set exception of type ArgumentException for each property with a try-catch block 
         */



        // Create private attributes.
        private int _age;
        private string _lName, _fName;
        private double _height, _weight;

        // Constructor to make lName and fName mandatory
        public Person(String firstName, string lastName)
        {
            this.FName = firstName;
            this.LName = lastName;
        }

        // Create public properties and implement validation

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }


        public int Age // set validation if Age is set to anything else than a positive whole number.
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value; // If value is greater than zero set age
                }
                else
                    throw new ArgumentException("Age must be greater than zero!");
            }
        }

        public string FName
        {
            get { return _fName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name can not be null or empty!");
                }
                if (value.Length < 2 || value.Length >= 11)
                {
                    throw new ArgumentException("Your name must be 2 or 10 characters long!");
                }

                _fName = value; // Dont need an else here, this is the same thing!
            }
        }

        public string LName
        {
            get { return _lName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name can not be null or empty");
                }

                if (value.Length < 3 || value.Length >= 16)
                {
                    throw new ArgumentException("Your last name must be 3 or 15 characters");
                }
                _lName = value; // Dont need an else here, this is the same thing!
            }
        }

        public override string ToString()
        {
            return $"{FName} {LName} {Age}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class PersonHandler
    {
        //public int Age { get; set; }
        //public string Fname { get; set; }
        //public string Lname { get; set; }
        //public double Height { get; set; }
        //public double Weight { get; set; }
        //public PersonHandler(int age, string fname, string lname, double height, double weight)
        //{
        //    this.Age = age;
        //    this.Fname = fname;
        //    this.Lname = lname;
        //    this.Height = height;
        //    this.Weight = weight;
        //}
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public int GetAge(Person pers)
        {
            return pers.Age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(fname, lname);
            person.Age = age;
            person.Height = height;
            person.Weight = weight;

            return person;
        }
    }
}

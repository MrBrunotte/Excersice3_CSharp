using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Inheritence
{
    public abstract class Animal
    {
        // public properties
        public string Name { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        // constructor to instatiate (create an Animal object) an Animal 
        public Animal(string name, string type, int weight, int height)
        {
            this.Name = name;
            this.Type = type;
            this.Weight = weight;
            this.Height = height;
        }


        // abstract class named DoSound
        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"{Name} {Type} {Weight} {Height}";
        }
    }

   
}

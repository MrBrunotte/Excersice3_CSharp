using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    public class Dog : Animals
    {
        // create one unique property
        public string Breed { get; set; }

        public Dog(string name, string type, int weight, int height, string breed) : base(name, type, weight, height)
        {
            this.Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("WOFF WOFF");
        }

        // polymorfism 
        public override string Stats()
        {
            return $"{base.Stats()} {Breed}";
        }

        public string ReturnString()
        {
            return $"\t\"This method returns this useless string\"";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    // Subclass Horse inherits from Animal
    public class Horse : Animals
    {
        public string Color { get; set; }

        public Horse(string name, string type, int weight, int height, string color) : base(name, type, weight, height)
        {
            this.Color = color;
        }

        // implement and override the DoSound method so the horse makes a sound
        public override void DoSound()
        {
            Console.WriteLine("EEEEAHHH EEEEAHHH");
        }

        public override string Stats()
        {
            return $"{base.Stats()} {Color}";
        }
    }
}

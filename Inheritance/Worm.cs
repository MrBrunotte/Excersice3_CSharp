using Inheritence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Worm : Animals
    {
        public string Slimy { get; set; }

        public Worm(string name, string type, int weight, int height, string slimy) : base(name, type, weight, height)
        {
            this.Slimy = slimy;
        }
        public override void DoSound()
        {
            Console.WriteLine("Worms don't make sounds!");
        }

        public override string Stats()
        {
            return $"{base.Stats()} {Slimy}";
        }
    }
}

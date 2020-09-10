using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    public class Pelican : Bird
    {
        public string Color { get; set; }

        public Pelican(string name, string type, int weight, int height, int wingspan, string color) : base(name, type, weight, height, wingspan)
        {
            this.Color = color;
        }

        public override string Stats()
        {
            return $"{base.Stats()} {Color}";
        }
    }
}
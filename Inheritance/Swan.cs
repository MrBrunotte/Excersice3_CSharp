using Inheritence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Swan : Bird
    {
        public string Color { get; set; }
        public Swan(string name, string type, int weight, int height, int wingspan, string color) : base(name, type, weight, height, wingspan)
        {
            this.Color = color;
        }

        public override string Stats()
        {
            return $"{base.Stats()} {Color}";
        }
    }
}

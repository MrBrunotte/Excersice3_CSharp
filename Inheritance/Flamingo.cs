using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    public class Flamingo : Bird
    {
        public string LenghtOfLegs { get; set; }
        public Flamingo(string name, string type, int weight, int height, int wingspan, string lenghtoflegs) : base(name, type, weight, height, wingspan)
        {
            this.LenghtOfLegs = lenghtoflegs;
        }
    }
}

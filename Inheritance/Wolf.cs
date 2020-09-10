using Inheritence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Wolf : Animals
    {
        public string Fangs { get; set; }

        public Wolf(string name, string type, int weight, int height, string fangs) : base(name, type, weight, height)
        {
            this.Fangs = fangs;
        }

        public override void DoSound()
        {
            Console.WriteLine("AOUUUUUU AAAOOOUUUUU");
        }

        public override string Stats()
        {
            return $"{base.Stats()} {Fangs}";
        }
    }
}

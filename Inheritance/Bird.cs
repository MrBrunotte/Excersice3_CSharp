using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    public class Bird : Animal
    {
        public int WingSpan { get; set; }
        public Bird (string name, string type, int weight, int height, int wingspan) : base(name, type, weight, height)
        {
            this.WingSpan = wingspan;
        }
        public override void DoSound()
        {
            Console.WriteLine("KvittElIkvitt");
        }

        public override string Stats()
        {
            return $"{base.Stats()} {WingSpan}";
        }
    }
}

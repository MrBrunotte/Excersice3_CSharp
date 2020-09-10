using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Inheritence
{
    public class HedgeHog : Animals
    {
        public string NrOfSpikes { get; set; }

        public HedgeHog(string name, string type, int weight, int height, string nrofspikes) : base(name, type, weight, height)
        {
            this.NrOfSpikes = nrofspikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("Hedgehogs dont talk, they just spear you with their spikes!");
        }

        public override string Stats()
        {
            return $"{base.Stats()} {NrOfSpikes}";
        }
    }
}

using Inheritence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // skapa class Wolfman that inherits from Wolf and implements the Interface IPerson
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, string type, int weight, int height, string fangs) : base(name, type, weight, height, fangs)
        {

        }

        public void Talk()
        {
            Console.WriteLine("I am the WOLFMAN!");
        }

    }
}

using Inheritence;
using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        /* FRÅGOR:
         * Om vi under utveckling kommer fram till att alla fåglar behöver samma attribut så'
         * lägger vi dem i klassen Bird efter som det är basklassen och alla andra fråglar ärver
         * från den klassen.
         * 
         * Om alla djur behöver nya attribut så lägger vi dom i basklassen Animal eftersom alla
         * ärver från den.
         */
        static void Main(string[] args)
        {
            Horse horse = new Horse("Stinger", "racer", 250, 115, "Brown");
            Wolfman wolfman = new Wolfman("Mr Wolfman", "Dangerous", 150, 2, "Sharp ones");
            Bird bird = new Bird("Donald", "Cartoon bird", 5, 10, 0);
            Dog dog = new Dog("Hedda", "Medium size", 13, 25, "Boston Terrier");
            Flamingo flamingo = new Flamingo("Pinky", "Ling legged bird", 4, 1, 2, "looong");
            HedgeHog hedgeHog = new HedgeHog("Spiky", "Sticky", 25, 20, "Thousands");
           
            horse.Color = "Black";

            Console.WriteLine(horse.Color);
            Console.WriteLine(wolfman.Fangs);
            wolfman.Talk();
            bird.DoSound();
            dog.DoSound();
            hedgeHog.DoSound();
            horse.DoSound();
            

            

        }
    }
}

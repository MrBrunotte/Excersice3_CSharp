using Inheritence;
using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse("Stinger", "racer", 250, 115, "Brown");
            Wolfman wolfman = new Wolfman("Mr Wolfman", "Dangerous", 150, 2, "Sharp ones");
            Bird bird = new Bird("Donald", "Cartoon bird", 5, 10, 0);
            Flamingo flamingo = new Flamingo("Pinky", "Ling legged bird", 4, 1, 2, "looong");
            //Flamingo f = new Flamingo
            //{
            //    Name = "Pinky",
            //    Type = "long legs",
            //    Weight = 5,
            //};
            horse.Color = "Black";

            Console.WriteLine(horse.Color);
            Console.WriteLine(wolfman.Fangs);
            wolfman.Talk();
            bird.DoSound();

            

        }
    }
}

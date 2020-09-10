using Inheritence;
using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        /* FRÅGOR ARV:
         * 13) Om vi under utveckling kommer fram till att alla fåglar behöver samma attribut så'
         * lägger vi dem i klassen Bird efter som det är basklassen och alla andra fråglar ärver
         * från den klassen.
         * 14) Om alla djur behöver nya attribut så lägger vi dom i basklassen Animal eftersom alla
         * ärver från den.
         * 
         * FRÅGOR POLYMORFISM
         * 9) Vi kan inte lägga till en häst i hund listan. Om vi använder keyword "is" så ser vi att
         * en häst "is not" a dog. Dog och häst ärver båda från Animal men de har olika attribut och
         * därför kan man inte lägga till en häst till dog listan.
         * 10) Listan måste vara av Placeholder type Generic
         * 13) 
         * 17) Metoden i ReturnString i klassen Dog är inte nåbar från Animals listan
         */
        static void Main(string[] args)
        {
            Horse horse = new Horse("Stinger", "racer", 250, 115, "Brown");
            Wolfman wolfman = new Wolfman("Mr Wolfman", "Dangerous", 150, 2, "Sharp ones");
            Bird bird = new Bird("Donald", "Cartoon bird", 5, 10, 0);
            Dog dog = new Dog("Hedda", "Medium size", 13, 25, "Boston Terrier");
            Dog dog1 = new Dog("Korven", "Medium size", 8, 15, "Fralla");
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

            // Polymorfism
            Console.WriteLine("\n----- Polymorfism section -----\n");
            List<Animals> animals = new List<Animals>();
            animals.Add(dog);
            animals.Add(dog1);
            animals.Add(hedgeHog);
            animals.Add(horse);
            animals.Add(bird);
            animals.Add(flamingo);
            animals.Add(wolfman);

            //3.3 - 8 skapa en lista för hundar
            List<Dog> dogs = new List<Dog>();
            //dogs.Add(horse);


            
           
            foreach (var animal in animals)
            {
                if (animal is IPerson person)
                {
                    // todo this does not work, it prints the sound of the wolf!
                    person.Talk();
                }
                Console.WriteLine($"Print all animal stats: {animal.Stats()}");
                Console.WriteLine($"Print animal type: {animal.GetType().Name}");
                Console.WriteLine($"What does the {animal.GetType().Name} say?");
                animal.DoSound();
                Console.WriteLine("\n");
            }

            // print stats for dog in the animal list
            Console.WriteLine("Print the dogs in the animals list!");
            foreach (var animal in animals)
            {
                
                if (animal is Dog dogType)
                {
                    Console.WriteLine($"\tPrint only stats if animal is dog: {animal.Stats()}");
                    Console.WriteLine(dogType.ReturnString());
                }
            }
            
        }
    }
}

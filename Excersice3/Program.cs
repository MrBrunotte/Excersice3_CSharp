using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Instantiate to see if Person is accessible
            // Person person = new Person();
            // can I add the variables? YES
            // person.Age = 10;

            try
            {
                // Instatiat new personHandler
                PersonHandler personHandler = new PersonHandler();
                // Create me
                var me = personHandler.CreatePerson(48, "Stefan", "Brunotte", 182, 95);
                
                // set age for me
                personHandler.SetAge(me, 38);
                Console.WriteLine(me);

                //------test errors Uncomment to se validation-------

                //var me2 = personHandler.CreatePerson(-48, "Stefan", "Brunotte", 182, 95);
                //var me3 = personHandler.CreatePerson(48, "Stefan", "Brunotte", 182, 95);
                //personHandler.SetAge(me3, -38);
                //Console.WriteLine(me3);
                //var meS = personHandler.CreatePerson(48, "S", "Brunotte", 182, 95);
                //Console.WriteLine(meS);
                //var meBr = personHandler.CreatePerson(48, "Stefan", "Br", 182, 95);
                //Console.WriteLine(meBr);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

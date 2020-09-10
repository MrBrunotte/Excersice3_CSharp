using System;
using System.Collections.Generic;

namespace Polymorfism3._4
{
    class Program
    {
        /*
         * 11) Nör man behärskar polymorfism så kommer man att skriva mindre kod.
         * Vi behöver inte hitta på nya namn på metoder som i stort gör samma sak
         * men endast skiljer sig i små detaljer.
         * 
         * 12) Om man bygger in bra struktur så gör polymorfismen att man kommer 
         * skriva mindre kod eftersom man kan ändra de små detaljerna som skiljer
         * men behålla den initala egenskapen en metod skall implementera.
         * 
         * En abstract klass skapar funktionalitet som subklasser kan implementera
         * eller skriva över (override).
         * Ett interface definierar endast funktionaliteten och man kan inte implementera
         * den som i den abstrakta klassen.
         */

        static void Main(string[] args)
        {

            List<UserError> userErrors = new List<UserError>();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new Class1());
            userErrors.Add(new Class2());
            userErrors.Add(new Class3());


            foreach (var userError in userErrors)
            {
                Console.WriteLine(userError.UEMessage());
            }
        }
    }
}

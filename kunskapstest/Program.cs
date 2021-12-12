using System;
using System.Linq;
using System.Collections.Generic;
namespace kunskapstest
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Fråga1();
            //Fråga2();
            Fråga3();
            //Fråga4();

        }
        public enum antalgrejer { Grej1, Grej2, Grej3, Grej4, Grej5, Grej6, Grej7, }
        static void Fråga1()
        {
            /// Förklara vad som kommer skrivas ut och varför.
            /// syftet med uppgiften är du ska förstå vad det är som händer i framförallt forloopen 
            /// och tilldelningen av strängens värde.
            /// Men ni får även en check av enums på samma gång.
            Random rnd = new Random();
            antalgrejer minagrejer = (antalgrejer)rnd.Next(0, 4);
            var var1 = 0;

            for (int i = 0; i < ((int)minagrejer * ((int)minagrejer + 2)); i++)
            {
                var1++;
            }
            string utmatning = var1 > 10 ? "stor" : "liten";

            Console.WriteLine(utmatning);
        }
        static void Fråga2()
        {

            for (int i = 1; i < 101; i++)
            {
                string input = "";
                if (i % 3 == 0)
                {
                    input += "fizz";
                }
                if (i % 5 == 0)
                {
                    input += "buzz";
                }
                Console.WriteLine(input == "" ? i : input);

            }
        }
        static void Fråga3()
        {
            /// I denna fråga vill jag att du hittar ett sätt som tillförlitligt tar fram alla personer som är äldre än 25 och samtidigt bor i göteborg och sedan skriver ut deras idn.
            /// Men ni får inte använda forloopar eller foreach loopar. 
            /// för att läsa uppgiften så kommer ni behöva googla efter lösingar. Sökordet ni får är LINQ. ni skapar predicates genom att skriva x=>x.egenskapen ni söker efter
            List<Person> listamedpersoner = new();
            listamedpersoner.AddRange(PopulatePeople());
            List<Person> urval = new();
            urval.AddRange(listamedpersoner.FindAll(x => (x.age >= 25) && (x.homecity == Stad.göteborg)));

        }
        static List<Person> PopulatePeople()
        {
            /// detta är en metod som populerar listan, ni får läsa igenom den för att förstå vad som händer här,
            /// men ni får inte ändra den.

            List<Person> people = new();
            List<string> name = new() { "Erik", "David", "Daniel", "Axel", "Emma", "Yen", "Kristina", "Peppo", "Simon", "Eric", "Alexander" };
            Random rand = new();

            for (int i = 0; i < 30; i++)
            {
                people.Add(new Person(name[rand.Next(0, name.Count)], rand.Next(15, 75), (Stad)rand.Next(0, 5)));
            }
            return people;
        }
        static void Fråga4()
        {
            /// De förra uppgifterna kan ha varit kluriga, men syftet är att jag ska se vart ni är och om ni kan anpassa er till otillräcklig information som ni måste leta redapå själva.Här kommer en drös lättare uppgifter.
            /// 
            ///Uppgift 4.1 skriv ut strängen meddelande baklänges.
            string meddelande = "Detta är ett meddelande";
            for (int i = meddelande.Length; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
        ///uppgift 4.2. skriv en metod som skriver ut trianglar av typen nedan. Man ska i metoden kunna välja hur många rader som ska skrivas ut
        /*   *
         *   **
         *   ***
         *   ****
         *   *****
        */
        public void Skrivtrianglar()
        {
            {
                int antalrader = 5;
                string stjärnor = "";
                for (int i = 0; i < antalrader; i++)
                {
                    stjärnor += "*";
                    Console.WriteLine(stjärnor);
                }
            }
        }
            /// uppgift 4.3 skapa en metod som tar in två strängar, och skriver ut den av dem som har flest antaltecken. mellanslag ska inte räknas.
            public void Räknatecken(string meddelande1, string meddelande2)
            {
            string meddelande1trimmed = meddelande1.Replace(" ", "");
            string meddelande2trimmed = meddelande2.Replace(" ", "");
            Console.WriteLine(meddelande1trimmed.Length > meddelande2trimmed.Length ? meddelande1 : meddelande2);
            
            }

        }
    }



using System;
using System.Linq;
using System.Collections.Generic;
namespace kunskapstest
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Fråga1();
            Fråga2();
            Fråga3();
            Fråga4();

        }
        public enum antalgrejer { Grej1, Grej2, Grej3, Grej4, Grej5, Grej6, Grej7, }
        static void Fråga1()
        {
            /// Förklara vad som kommer skrivas ut och varför.
            /// syftet med uppgiften är du ska förstå vad det är som händer i framförallt forloopen 
            /// och tilldelningen av strängens värde.
            /// Men ni får även en check av enums på samma gång.
            Random rnd = new Random();
            antalgrejer minagrejer = (antalgrejer)rnd.Next(0,4);
            var var1 = 0;

            for (int i = 0; i < ((int)minagrejer*((int)minagrejer+2)); i++)
            {
                var1++;
            }
            string utmatning = var1 > 10 ? "stor" : "liten";

            Console.WriteLine(utmatning);
        }
        static void Fråga2()
        {
            /// i denna uppgift vill jag att du skriver ut talen 1 till 100.
            /// Men, jag vill att varje om talet är delbart i 3 så ska programmet i stället skriva ut "pang"
            /// om talet är delbart i 5 vill jag att programmet istäälet skriver ut talet "boom"
            /// om talet är delbart i 3 OCH 5 ska programmet skriva ut "pang boom";
            /// exempel på hur det ska se ut 
            /*1
             * 2
             * pang
             * 4
             * boom
             * pang
             * 7
             * 8
             * pang
             * boom
             */
        }
        static void Fråga3()
        {
           /// I denna fråga vill jag att du hittar ett sätt som tillförlitligt tar fram alla personer som är äldre än 25 och samtidigt bor i göteborg och sedan skriver ut deras idn.
           /// Men ni får inte använda forloopar eller foreach loopar. 
           /// för att läsa uppgiften så kommer ni behöva googla efter lösingar. Sökordet ni får är LINQ.
            List<Person> listamedpersoner = new();
            listamedpersoner.AddRange(PopulatePeople());
            List<Person> urval = new();
            //urval.AddRange();

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
                people.Add(new Person(name[rand.Next(0, name.Count)],rand.Next(15,75), (Stad)rand.Next(0,5)));
            }
            return people;
        }
        static void Fråga4()
        {
            /// De förra uppgifterna kan ha varit kluriga, men syftet är att jag ska se vart ni är och om ni kan anpassa er till otillräcklig information som ni måste leta redapå själva.Här kommer en drös lättare uppgifter.
            /// 
            ///Uppgift 4.1 skriv ut strängen meddelande baklänges.
            string meddelande = "Detta är ett meddelande";

            ///uppgift 4.2. skriv en metod som skriver ut trianglar av typen nedan. Man ska i metoden kunna välja hur många rader som ska skrivas ut
            /*   *
             *   **
             *   ***
             *   ****
             *   *****
            */
            /// uppgift 4.3 skapa en metod som tar in två strängar, och skriver ut den av dem som har flest antaltecken. mellanslag ska inte räknas.
            
        }
        }
    }


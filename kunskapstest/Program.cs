using System;

namespace kunskapstest
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            fråga1();
            fråga2();
            fråga3();
            fråga4();

        }
        public enum antalgrejer { Grej1, Grej2, Grej3, Grej4, Grej5, Grej6, Grej7, }
        static void fråga1()
        {
            /// Förklara vad som kommer skrivas ut och varför.
            /// syftet med uppgiften är du ska förstå vad det är som händer i framförallt forloopen 
            /// och tilldelningen av strängens värde.
            
            antalgrejer minagrejer = antalgrejer.Grej5;
            var var1 = 0;

            for (int i = 0; i < ((int)minagrejer*((int)minagrejer+2)); i++)
            {
                var1++;
            }
            string utmatning = var1 > 10 ? "stor" : "liten";

            Console.WriteLine(utmatning);
        }
        static void fråga2()
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
        static void
    }
}

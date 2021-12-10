using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kunskapstest
{
    public enum Stad { Stockholm,göteborg, Malmö,Örebro,Norrköping}
    internal class Person
    {

        public string Name { get; set; }
        public Guid Id { get; set; }
        public int age { get; set; }
        public Stad homecity { get; set; }
        
        public Person(string namn,int ålder,Stad hemstad)
        {
            Name= namn;
            Id = new Guid();
            age = ålder;
            homecity = hemstad;
        }
    }
}

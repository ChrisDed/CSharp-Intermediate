using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = Person.Parse("Chris");
            person.Introduce("Mosh");

            Person p = Person.Parse("Mosh");
            p.Introduce(person.Name);
        }
    }
}

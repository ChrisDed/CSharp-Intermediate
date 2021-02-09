using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(new DateTime(1995, 6, 13));
            Console.WriteLine(person.Age);
        }
    }
}

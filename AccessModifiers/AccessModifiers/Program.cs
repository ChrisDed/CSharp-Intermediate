using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}

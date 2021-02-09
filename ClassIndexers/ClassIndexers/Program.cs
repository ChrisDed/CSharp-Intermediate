using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Chris";
            Console.WriteLine(cookie["name"]);
        }
    }
}

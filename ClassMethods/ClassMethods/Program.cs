using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            UseOut();
            UseParams();
            UsePoints();
        }

        static void UseOut()
        {
            // try catch does the same thing as 'out' modifier.
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            int number;
            bool result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }

        static void UseParams()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }

        static void UsePoints()
        {
            try
            {
                Point point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error has occured.");
            }
        }
    }
}

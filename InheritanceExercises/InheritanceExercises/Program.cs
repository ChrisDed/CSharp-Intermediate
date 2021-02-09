using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.LogAllElements();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.LogAllElements();
        }
    }
}

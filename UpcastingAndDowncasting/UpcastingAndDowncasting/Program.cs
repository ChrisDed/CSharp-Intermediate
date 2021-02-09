using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncasting
{

    class Program
    {
        static void Main(string[] args)
        {
            // Down casting
            // Even though at compile time the type of our shape object
            // is Shape, at runtime its type will be Text
            Shape shape = new Text();
            Text text = (Text)shape;
        }

        public static void UpCasting()
        {
            Text text = new Text();
            Shape shape = text;
            //// text and shape are both references to the same
            //// object in memory, but they have different views
            //// text will see properties and methods from Text
            //// shape will see properties and methods from Shape

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width); // 100

            // Example of where we use conversion in a real world scenario
            // StreamReader takes a Stream object as a parameter
            // In .NET, Stream is the base/parent of every kind of stream
            // e.x File or Memory Streams derive from the Stream class
            // So, we can pass a MemoryStream to the StreamReader
            // even though it takes a Stream object.
            //StreamReader reader = new StreamReader(new MemoryStream());

            // ArrayList is a list that stores objects
            // Since all classes derive from the Object class
            // You can store any thing such as ints, strings,
            // and even our new Text object.
            // These are all casted to Object when added to the list
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("lol");
            list.Add(new Text());

            // We shouldn't use ArrayLists as it takes multiple types
            // As you can get exceptions when converting list elements
            // to target types.

            var anotherList = new List<Shape>();
        }
    }
}

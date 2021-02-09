using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("lol");
            list.Add(DateTime.Today);
            // There's a problem with ArrayLists
            // You lose type safety as you can pass any type in them
            // Which means if you try to cast the second element to an int
            // you will get an exception

            var number = (int) list[1]; // InvalidCastException
            // Another bad thing with ArrayLists.Add(), is that it takes
            // an object as an argument, which if you pass a
            // value type, Boxing will happen.
            // Also, when you get that value back and cast it,
            // Unboxing happens. Int and DateTime will have Boxing/Unboxing
            // as they are value types. String won't as it is a reference
            // type.

            // A better way is to use a generic list

            var anotherList = new List<int>();
            anotherList.Add(1);
            // List.Add() takes an argument for what you set the list to
            // so you get type safety. Also, every element will be an int
            // so no Boxing will happen.

            // Point is, if you are working with a method, and the
            // argument taken is an object, be wary that if you pass a
            // value type, there will be Boxing/Unboxing
        }
    }
}

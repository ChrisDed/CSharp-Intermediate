using System;

namespace MethodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            // Any code specific to the circle itself
            Console.WriteLine("Draw a circle");
        }
    }
}

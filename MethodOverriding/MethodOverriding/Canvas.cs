using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                // On runtime, the derived shapes overrided method
                // will be executed
                // execute Program to see for yourself
                shape.Draw();
            }
        }
    }
}

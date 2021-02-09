using System;

namespace ClassMethods
{
    public class Point
    {
        public int X;
        public int Y;

        // Constructor
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Methods
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null) // defensive programming
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }

}

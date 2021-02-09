using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndMembers
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a rectangle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rec = new Rectangle();
            rec.Draw();
        }
    }
}

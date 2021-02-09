using System;

namespace Amazon
{

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            // not good practice to instantiate an object in a method
            // will see a better way to do this after learning
            // Interfaces
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
        }
    }
}

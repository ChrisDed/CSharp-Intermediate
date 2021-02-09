using System;

namespace InterfacesExercises
{
    public class ChangeVideoRecord : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changed status of video in DB to processing");
        }
    }
}

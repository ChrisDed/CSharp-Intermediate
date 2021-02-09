using System;

namespace InterfacesExercises
{
    public class MailNotification : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Emailing owner...");
        }
    }
}

using System;

namespace InterfacesExercises
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud storage...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunWatch();
            StackOverflowPost();
        }

        static void StackOverflowPost()
        {
            Post post = new Post("Some Title", "Some terrible description");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            Console.WriteLine(post.GetVotes());
        }

        static void RunWatch()
        {
            StopWatch watch = new StopWatch();
            bool isTrue = true;

            do
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    return;
                }
                else if (input.ToLower() == "start")
                {
                    watch.Start();
                }
                else if (input.ToLower() == "stop")
                {
                    watch.Stop();
                    Console.WriteLine(watch.Duration);
                }
                else
                {
                    isTrue = false;
                }
            } while (isTrue);
        }
    }
}

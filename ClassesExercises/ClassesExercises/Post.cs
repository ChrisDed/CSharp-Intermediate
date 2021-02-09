using System;

namespace ClassesExercises
{
    public class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime TimeCreated { get; private set; }
        private int _votes;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.TimeCreated = DateTime.Now;
        }

        public void UpVote()
        {
            _votes++;
        }

        public void DownVote()
        {
            _votes--;
        }

        public int GetVotes()
        {
            return _votes;
        }
    }
}

using System;

namespace ClassesExercises
{
    public class StopWatch
    {
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        private bool _isRunning;
        public TimeSpan Duration
        {
            get
            {
                return StopTime - StartTime;
            }
        }

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("StartTime");

            _isRunning = true;
            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            StopTime = DateTime.Now;
            _isRunning = false;
        }
    }
}

using System;

namespace task2
{
    public class EventCame : EventArgs
    {
        public DateTime Time;
        public EventCame(DateTime time)
        {
            Time = time;
        }
    }
}

using System;
using System.Threading;

namespace LostAndFound
{
    public class TimedEvents
    {
        public enum WriteSpeed { Normal = 40, Fast = 20, Slow = 80 }

        public static void TimedWrite(string text, WriteSpeed speed = WriteSpeed.Normal)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep((int)speed);
            }
        }
    }
}

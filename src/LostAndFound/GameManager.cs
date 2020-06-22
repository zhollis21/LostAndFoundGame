﻿namespace LostAndFound
{
    public static class GameManager
    {
        public static void StartGame()
        {
            PrintIntro();
        }

        private static void PrintIntro()
        {
            TimedEvents.TimedWrite(
                "\n\n\t\tLost and Found..." +
                "\n\t\t\tThe Ultimate Survival Game..." +
                "\n\n\t\t\tWritten and Developed by: Zach Hollis\n\n",
                TimedEvents.WriteSpeed.Slow);
        }
    }
}

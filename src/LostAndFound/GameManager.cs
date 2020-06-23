namespace LostAndFound
{
    public static class GameManager
    {
        public static void StartGame()
        {
            PrintIntro();
        }

        private static void PrintIntro()
        {
            var introText =
                "\n\n\t\tLost and Found..." +
                "\n\t\t\tThe Ultimate Survival Game..." +
                "\n\n\t\t\tDeveloped by: Zach and Paula Hollis\n\n";

            TimedEvents.TimedWrite(introText, TimedEvents.WriteSpeed.Slow);
        }
    }
}

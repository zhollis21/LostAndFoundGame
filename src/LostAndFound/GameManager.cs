using System;

namespace LostAndFound
{
    public static class GameManager
    {
        public static void StartGame()
        {
            PrintIntro();

            ManageGameActions();
        }

        private static void PrintIntro()
        {
            var introText =
                "\n\n\t\tLost and Found..." +
                "\n\t\t\tThe Ultimate Survival Game..." +
                "\n\n\t\t\tDeveloped by: Zach and Paula Hollis\n\n";

            TimedEvents.TimedWrite(introText, TimedEvents.WriteSpeed.Slow);
        }

        private static void ManageGameActions()
        {
            PrintMainMenu();
            char userInput = GetUserInput();
        }

        private static void PrintMainMenu()
        {
            var menuText =
                "\n\nMain Menu:\n\t" +
                "Press 'S' to Start a New Game\n\t" +
                "Press 'C' to Continue a Previous Game\n\t" +
                "Press 'L' to View the Leaderboards\n\t" +
                "Press 'H' for Help and FAQ\n\t" +
                "Press 'Q' to Quit\n";

            TimedEvents.TimedWrite(menuText, TimedEvents.WriteSpeed.Fast);
        }

        private static char GetUserInput()
        {
            char userInput = char.ToLower(Console.ReadKey(true).KeyChar);

            while(userInput != 's' && userInput != 'c' && userInput != 'l' && userInput != 'h' && userInput != 'q')
            {
                Console.Write("\n\nYour input is not valid. Please select one of the Main Menu options.");
                userInput = char.ToLower(Console.ReadKey(true).KeyChar);
            }          

            return userInput;
        }
    }
}

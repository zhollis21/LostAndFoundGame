using System;

namespace LostAndFound
{
    public static class GameManager
    {
        private enum MenuChoice { S, C, L, H, Q}

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
            MenuChoice userInput = GetUserInput();
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

        private static MenuChoice GetUserInput()
        { 
            while (true)
            {
                char userInput = char.ToUpper(Console.ReadKey(true).KeyChar);

                if (userInput == 'S')
                    return MenuChoice.S;

                if (userInput == 'C')
                    return MenuChoice.C;

                if (userInput == 'L')
                    return MenuChoice.L;

                if (userInput == 'H')
                    return MenuChoice.H;

                if (userInput == 'Q')
                    return MenuChoice.Q;
            }
        }
    }
}

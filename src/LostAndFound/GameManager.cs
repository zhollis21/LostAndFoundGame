using System;

namespace LostAndFound
{
    public static class GameManager
    {
        private enum MenuChoice { Start, Continue, Leaderboards, Help, Quit}

        public static void StartGame()
        {
            PrintIntro();

            Manages();
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
            MenuChoice userMenuChoice = GetUserMenuChoice();
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

        private static MenuChoice GetUserMenuChoice()
        { 
            while (true)
            {
                char userMenuChoice = char.ToUpper(Console.ReadKey(true).KeyChar);

                if (userMenuChoice == 'S')
                    return MenuChoice.Start;

                if (userMenuChoice == 'C')
                    return MenuChoice.Continue;

                if (userMenuChoice == 'L')
                    return MenuChoice.Leaderboards;

                if (userMenuChoice == 'H')
                    return MenuChoice.Help;

                if (userMenuChoice == 'Q')
                    return MenuChoice.Quit;
            }
        }
    }
}

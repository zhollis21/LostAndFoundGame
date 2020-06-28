using System;

namespace LostAndFound
{
    public static class GameManager
    {
        private enum MenuChoice { Start, Continue, Leaderboard, Help, Quit }

        public static void StartGame()
        {
            PrintIntro();

            ManageMenuActions();
        }

        private static void PrintIntro()
        {
            var introText =
                "\n\n\t\tLost and Found..." +
                "\n\t\t\tThe Ultimate Survival Game..." +
                "\n\n\t\t\tDeveloped by: Zach and Paula Hollis\n\n";

            TimedEvents.TimedWrite(introText, TimedEvents.WriteSpeed.Slow);
        }

        private static void ManageMenuActions()
        {
            PrintMainMenu();
            MenuChoice userMenuChoice = GetUserMenuChoice();

            if (userMenuChoice == MenuChoice.Start)
            {
                Game.StartNewGame();
            }

            if (userMenuChoice == MenuChoice.Continue)
            {
                Game.ContinuePreviousGame();
            }

            if (userMenuChoice == MenuChoice.Leaderboard)
            {
                PrintLeaderboard();
            }

            if (userMenuChoice == MenuChoice.Help)
            {
                HelpUser();
            }

            if (userMenuChoice == MenuChoice.Quit)
            {
                TimedEvents.TimedWrite("\n\n\tThank you for playing!", TimedEvents.WriteSpeed.Slow);
            }
        }

        private static void PrintMainMenu()
        {
            var menuText =
                "\n\nMain Menu:\n\t" +
                "Press 'S' to Start a New Game\n\t" +
                "Press 'C' to Continue a Previous Game\n\t" +
                "Press 'L' to View the Leaderboard\n\t" +
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
                    return MenuChoice.Leaderboard;

                if (userMenuChoice == 'H')
                    return MenuChoice.Help;

                if (userMenuChoice == 'Q')
                    return MenuChoice.Quit;
            }
        }

        private static void PrintLeaderboard()
        {
            Console.WriteLine("\nPrinting the Leaderboad...");
        }

        private static void HelpUser()
        {
            string helpText =
                "\n\nHelp:\n\t" +                
                "\n\tLost and Found is all about making smart choices.\n\t" +
                "The game gives you the freedom to do anything you wish, but those choices might have swift consequences...\n\t" +
                "\n\tHaving trouble surviving?\n\t" +
                "Health can be recovered by sleeping or keeping your hunger level moderate to full.\n\t" +
                "Try to limit your exploring until to have some food stored up.\n\t" +
                "When exploring, try making a sturdy camp in the center of a region to use as a base of operations.\n\t" +
                "\n\tDoes your game freeze up when you select \"Continue\"?\n\t" +
                "Most likely your game data file has been moved or corrupted.\n\t" +
                "Unfortunately you will need to start a new game.\n\t" +
                "\n\tEncountering bugs or glitches?\n\t" +
                "Contact the developers at: zhollis21@gmail.com\n\t" +
                "Be sure to include a detailed discription of the problem and a screenshot if possible.\n\t" +
                "\n\tThanks for playing!" +
                "\n\nPress anything to return to the Main Menu...\n";

            TimedEvents.TimedWrite(helpText, TimedEvents.WriteSpeed.Fast);
        }
    }
}

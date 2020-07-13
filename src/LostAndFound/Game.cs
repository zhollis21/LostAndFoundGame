using System;

namespace LostAndFound
{
    public class Game
    {
        private enum MenuChoice { Explore, GatherFood, BuildOrFortifyCamp, Inventory, MainMenu }

        private int _day = 1;

        public static void StartNewGame()
        {
            TimedEvents.TimedWrite(
                "\n\tAre you sure you want to start a new game? ('Y' or 'N')\n\t" +
                "This will erase your previous survival game data!\n\t");

            if (!IsUserInputYes())
            {
                return;
            }

            TimedEvents.TimedWrite("\n\tPlease enter your full name and then press < Enter >: ");
            string playerName = Console.ReadLine();
            // TODO: validate player name and what to do with it.

            TimedEvents.TimedWrite("\n\tDo you want to hear the intro story? ('Y' or 'N')\n\t");

            if (IsUserInputYes())
            {
                PrintIntroStory();
            }

            ManageGameActions();
        }

        public static void ContinuePreviousGame()
        {
            Console.WriteLine("\nContinuing a game...");
        }

        private static void ManageGameActions()
        {
            MenuChoice userMenuChoice;

            do
            {
                PrintGameActionsMenu();
                userMenuChoice = GetUserGameActionsMenuChoice();
                // TODO: check if userMenuChoice is any of the other options and tell it what to do.

            } while (userMenuChoice != MenuChoice.MainMenu);
        }

        private static void PrintGameActionsMenu()
        {
            TimedEvents.TimedWrite(
                "\n\tWhat do you want to do now?\n\t\t" +
                "Press 'E' to Explore\n\t\t" +
                "Press 'G' to Gather Food\n\t\t" +
                "Press 'B' to Build/Fortify Camp\n\t\t" +
                "Press 'I' to go to your Inventory\n\t\t" +
                "Press 'M' to go to the Main Menu\n\t",
                TimedEvents.WriteSpeed.Fast);
        }

        private static MenuChoice GetUserGameActionsMenuChoice()
        {
            while (true)
            {
                char userMenuChoice = char.ToUpper(Console.ReadKey(true).KeyChar);

                if (userMenuChoice == 'E')
                    return MenuChoice.Explore;

                if (userMenuChoice == 'G')
                    return MenuChoice.GatherFood;

                if (userMenuChoice == 'B')
                    return MenuChoice.BuildOrFortifyCamp;

                if (userMenuChoice == 'I')
                    return MenuChoice.Inventory;

                if (userMenuChoice == 'M')
                    return MenuChoice.MainMenu;
            }
        }

        private static bool IsUserInputYes()
        {
            char userInput;

            do
            {
                userInput = char.ToUpper(Console.ReadKey(true).KeyChar);

            } while (userInput != 'Y' && userInput != 'N');

            return userInput == 'Y';
        }

        private static void PrintIntroStory()
        {
            // TODO: grammar and spellcheck this text.
            TimedEvents.TimedWrite(
                "\n\n\tYou: ...Uggh... Where am I???\thello... Hello?!... Can anyone hear me ? !...\n\n" +
                "\tYou have woken up in the middle of a dark forest with no one in sight.\n\t" +
                "You have absolutely no memory of who you are or where you are at.\n\t" +
                "You examine yourself trying to figure out something about yourself and why you are here...\n\n\t" +
                "You are wearing worn out jeans, a dirt covered tee-shirt, and some old tennis shoes\n\t" +
                "You check your pockets... No luck, just an empty map..." +
                "\n\n\tYou are really starting to panic now!\n\t" +
                "You have no clue, who you are, where you are, or even what is going on!\n\n\t" +
                "Okay... Okay... You try to calm yourself down...\n\t" +
                "You tell yourself to just sit down and figure it out.\n\n\t" +
                "Okay, so you are lost in the middle of a forest...\n\t",
                TimedEvents.WriteSpeed.Slow);
        }

        private static void PrintGameStatus()
        {

        }
    }
}

using System;

namespace WizardGame
{
    public class TutorialClass
    {
        public string decision;
        public Wizard wizard1 = new Wizard();

        public void Tutorial()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Wizard Game!\n");
            Console.WriteLine("Time to create a wizard.");
            Console.WriteLine("What will be your wizard's name?\n");
            wizard1.name = Console.ReadLine();
            Console.WriteLine();
            wizard1.Introduce();
            Console.WriteLine("\nIn this game there are two basic skills. Attack, and Health. You can attack using spells.");
            wizard1.IncreaseStats();
            Console.WriteLine("For information about Attack, Health, or Spells. Press 1, 2, 3.\n(Press any other key to continue)");
            while (true)
            {
                decision = Console.ReadLine();
                switch (decision)
                {
                    case "1":
                        Console.WriteLine("\nAttack is the amount of damage your wizard does to an enemy.");
                        continue;
                    case "2":
                        Console.WriteLine("Health is the amount of damage your wizard can take before it dies.");
                        continue;
                    case "3":
                        Console.WriteLine("Currently you have four spells. Different spells are effective against different enemies.");
                        Console.WriteLine("As you use spells, you will be able to check how effective it was after use.");
                        continue;
                    default:
                        break;
                }
                break;
            }
            
            Console.WriteLine("It's time to fight your first enemy, a goblin! When you are ready, press enter.\n");
            Console.ReadLine();
            Console.WriteLine("\nYou are attacked by a goblin!");
            Console.WriteLine("Wizard Game is a turn based game. You currently have one option. Attack! Type (Attack) to select it.");
            Console.ReadLine();
            Console.WriteLine("Yowzers! You beat the goblin!\nNow you will enter the main game.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nPress any key to continue. . .");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}

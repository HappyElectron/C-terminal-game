using System;       

namespace WizardGame
{
    public class TutorialClass
    {
        public void Tutorial()
        {
            Wizard wizard1 = new Wizard();

            Console.WriteLine("Welcome to Wizard Game!");
            Console.WriteLine();
            Console.WriteLine("Time to create a wizard.");
            Console.WriteLine("What will be your wizard's name?");
            Console.WriteLine();
            wizard1.name = Console.ReadLine();
            Console.WriteLine();
            wizard1.Introduce();
            Console.WriteLine();
            Console.WriteLine("In this game there are three basic skills. Attack, Health, and Special.");
            wizard1.IncreaseStats();
            Console.WriteLine();
            Console.WriteLine("Attack is the amount of damage your wizard does to an enemy.");
            Console.WriteLine("Health is the amount of damage your wizard can take before it dies.");
            Console.WriteLine("A special is a move that your wizard can perform. Upgrading special will decrease the time between use.");
            Console.WriteLine("Currently you have two spells. Different spells are effective against different enemies.");
            Console.WriteLine("As you use spells against enemies, you will be able to check how effective it was after use, or later in the journal.");
            Console.WriteLine("It's time to fight your first enemy, a goblin! When you are ready, press enter.");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You are attacked by a goblin!");
            Console.WriteLine("Wizard Game is a turn based game. You currently have one option. Attack! Type (Attack) to select it.");
            string decision = Console.ReadLine();
            if (decision == "Attack")
            {
                
            }
        }
    }
}

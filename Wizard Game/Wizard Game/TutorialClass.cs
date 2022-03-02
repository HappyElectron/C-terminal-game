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
            Console.WriteLine("Pick one to invest in: (1) Attack, (2) Health, (3) Special");
            Console.WriteLine();
            byte tutAtrib = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            switch (tutAtrib)
            {
                case 1:
                    wizard1.attack += 1;
                    wizard1.AttackIncrease(wizard1.attack, wizard1.name);
                    break;
                case 2:
                    wizard1.health += 1;
                    wizard1.HealthIncrease(wizard1.health, wizard1.name);
                    break;
                case 3:
                    wizard1.special += 1;
                    wizard1.SpecialIncrease(wizard1.special, wizard1.name);
                    break;
            }
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

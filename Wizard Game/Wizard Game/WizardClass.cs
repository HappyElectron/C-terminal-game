using System;

namespace WizardGame
{
    public class Wizard
    {
        public static TutorialClass tutorial = Program.tutorial;
        public static Wizard wizard1 = tutorial.wizard1;
        public string name;
        public int attackLevel = 1;
        public int attack = 1;
        public int healthLevel = 1;
        public int health = 1;
        public int xp = 0;
        public int level = 1;
        public int maxHealth = 0;

        public void Introduce()
        {
            Console.WriteLine("Name: " + name + ".");
        }
        public void IncreaseStats()
        {
            Console.WriteLine("Pick one to invest in: (1) Attack, (2) Health\n");
            string tutAtrib = Console.ReadLine();
            Console.WriteLine();
            switch (tutAtrib)
            {
                case "1":
                    wizard1.attackLevel++;
                    wizard1.attack = 3* wizard1.attackLevel;
                    string attackLevelString = Convert.ToString(wizard1.attackLevel);
                    string attackString = Convert.ToString(wizard1.attack);
                    Console.WriteLine(name + "'s attack level has been increased to " + attackLevelString + "!\nThis means " + name + " now does " + attackString + " base damage.");
                    break;
                case "2":
                    wizard1.healthLevel = wizard1.healthLevel +1;
                    wizard1.health = wizard1.healthLevel * 5;
                    string healthLevelString = Convert.ToString(wizard1.healthLevel);
                    string healthString = Convert.ToString(wizard1.health);
                    Console.WriteLine(name + "'s health level has been increased to " + healthLevelString + "!\nThis means " + name + " now has {0} health points.",wizard1.health);
                    break;
                default:
                    Console.WriteLine("It seems you did not enter a valid option, so you get no bonus. " +
                        "\nSucks to suck");
                    break;
            }
        } 
    }
}

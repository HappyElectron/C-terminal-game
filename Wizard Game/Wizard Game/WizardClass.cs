using System;

namespace WizardGame
{
    public class Wizard
    {
        public static TutorialClass tutorial = new TutorialClass();
        public static Wizard wizard1 = tutorial.wizard1;
        public string name;
        public int attackLevel = 1;
        public int attack = 0;
        public int healthLevel = 1;
        public int health = 0;
        public string spell1;
        public string spell2;
        public string spell3;
        public string spell4;
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
                    attack = 5*wizard1.attackLevel;
                    string attackLevelString = Convert.ToString(wizard1.attackLevel);
                    string attackString = Convert.ToString(attack);
                    Console.WriteLine(name + "'s attack level has been increased to " + attackLevelString + "!\nThis means " + name + " now does " + attackString + " base damage.");
                    break;
                case "2":
                    wizard1.healthLevel++;
                    health = 10 * wizard1.healthLevel;
                    string healthLevelString = Convert.ToString(wizard1.healthLevel);
                    string healthString = Convert.ToString(health);
                    Console.WriteLine(name + "'s health level has been increased to " + healthLevelString + "!\nThis means " + name + " now has " + healthString + " health points.");
                    break;
                default:
                    Console.WriteLine("It seems you did not enter a valid option, so you get no bonus. " +
                        "\nSucks to suck");
                    break;
            }
        } 
    }
}

using System;

namespace WizardGame
{
    public class Wizard
    {
        public string name;
        public int attack = 2;
        public int health = 3;
        public string spell1;
        public string spell2;
        public string spell3;
        public string spell4;
        public int xp = 0;
        public int level = 1;
        public int maxHealth = 3;

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
                    attack += 5*level;
                    string attackString = Convert.ToString(attack);
                    Console.WriteLine(name + "'s attack has been increased to " + attackString + "!");
                    break;
                case "2":
                    health += 10*level;
                    maxHealth = health;
                    string healthString = Convert.ToString(health);
                    Console.WriteLine(name + "'s health has been increased to " + healthString + "!");
                    break;
                default:
                    Console.WriteLine("It seems you did not enter a valid option, so you get no bonus. " +
                        "\nSucks to suck");
                    break;
            }
        } 
    }
}

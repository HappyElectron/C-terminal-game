using System;

namespace WizardGame
{
    public class Wizard
    {
        public string name;
        public int attack;
        public int health;
        public int special;
        public string spell1;
        public string spell2;
        public string spell3;
        public string spell4;
        public int xp = 0;
        public int level = 0;

        public void Introduce()
        {
            Console.WriteLine("Your wizard's name is " + name + ".");
        }
        public void IncreaseStats()
        {
            Console.WriteLine("Pick one to invest in: (1) Attack, (2) Health, (3) Special\n");
            byte tutAtrib = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            switch (tutAtrib)
            {
                case 1:
                    attack += 1;
                    string attackString = Convert.ToString(attack);
                    Console.WriteLine(name + "'s attack has been increased to " + attackString + "!");
                    break;
                case 2:
                    health += 1;
                    string healthString = Convert.ToString(health);
                    Console.WriteLine(name + "'s health has been increased to " + healthString + "!");
                    break;
                case 3:
                    special += 1;
                    string specialString = Convert.ToString(special);
                    Console.WriteLine(name + "'s special has been increased to " + specialString + "!");
                    break;
            }
        }
        public void Attack(string spell1, string spell2, string spell3, string spell4)
        {
            Console.WriteLine("Which spell will you choose? " + spell1 + ", " + spell2 + " ");
        }
    }
}

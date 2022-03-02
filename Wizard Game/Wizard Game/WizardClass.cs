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

        public void Introduce()
        {
            
            Console.WriteLine("Your wizard's name is " + name + ".");
        }
        public void AttackIncrease(int attack, string name)
        {
            string attackString = Convert.ToString(attack);
            Console.WriteLine(name + "'s attack has been increased to " + attackString + "!");
        }
        public void HealthIncrease(int health, string name)
        {
            string healthString = Convert.ToString(health);
            Console.WriteLine(name + "'s health has been increased to " + healthString + "!");
        }
        public void SpecialIncrease(int special, string name)
        {
            string specialString = Convert.ToString(special);
            Console.WriteLine(name + "'s special has been increased to " + specialString + "!");
        }
        public void Attack(string spell1, string spell2, string spell3, string spell4)
        {
            Console.WriteLine("Which spell will you choose? " + spell1 + ", " + spell2 + " ");
        }
        public void TakeDamage(int monster.lowestDamage, int monster.highestDamage)
        {
            Random rand = new Random();
            public int damageTaken = rand.Next(monster.lowestDamage, monster.highestDamage);
        }
    }
}

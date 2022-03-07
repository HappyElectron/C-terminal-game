using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardGame
{
    public class Monster
    {
        public Wizard Wizard1 { get; set; }
        public int Health { get; set; }
        public int LowestXp { get; set; }
        public int HighestXp { get; set; }   
        public int LowestDamage { get; set; }
        public int HighestDamage { get; set; }
        public string MonsterName { get; set; }
        public string MonsterType { get; set; }
        public int damageDealt;
        public int damageTaken;
        public Monster(Wizard wizard1, int lowestXp, int highestXp, int lowestDamage, int highestDamage, string monsterName, string monsterType, int health)
        {
            Wizard1 = wizard1;
            LowestXp = lowestXp;
            HighestXp = highestXp;
            LowestDamage = lowestDamage;
            HighestDamage = highestDamage;
            MonsterName = monsterName;
            MonsterType = monsterType;
            Health = health;
        }
        public void Introduce()
        {
            Console.WriteLine("A {0} approaches you! \nIt is a {1} monster, and is suspectable to damge from {2} spells! \nFrom these spells, it will take twice as much damage as it ordinarily would.", MonsterName, MonsterType, "!!!filler value!!!");
        }
        public void Attack()
        {
            Console.WriteLine("The {0} attacks!",MonsterName);
            Random rand = new Random();
            damageDealt = rand.Next(LowestDamage, HighestDamage);
            Wizard1.health = Wizard1.health - damageDealt;
            Console.WriteLine("The {0} attacks! It deals {1} damage!" +
                "\nYour Wizard now has {2} health remaining.", MonsterName, damageDealt, Wizard1.health);
            if (Wizard1.health <= 0)
            {
                Console.WriteLine("You lose, fool. Your health is all gone." +
                    "\nYou were slain by a {0} and the game is now over.\n\nBad", MonsterName);
                Thread.Sleep(1000);
                Console.WriteLine("I do not know how to make the application quit from here so you're in an infinite loop now.");
                while (true)
                {}//leave user in a loop till they shut the app
            }
        }
        public void TakeDamage()
        {
            Console.WriteLine("successfully called takedamage()");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardGame
{
    public class Monster
    {
        public static TutorialClass tutorial = Program.tutorial;
        public static Wizard wizard1 = tutorial.wizard1;
        public int Health { get; set; }
        public int LowestXp { get; set; }
        public int HighestXp { get; set; }   
        public int LowestDamage { get; set; }
        public int HighestDamage { get; set; }
        public string MonsterName { get; set; }
        public string MonsterType { get; set; }
        public int damageDealt;
        public int damageTaken;
        public int spell;
        public int playerHealth;
        public Monster(int lowestXp, int highestXp, int lowestDamage, int highestDamage, string monsterName, string monsterType, int health)
        {
            LowestXp = lowestXp;
            HighestXp = highestXp;
            LowestDamage = lowestDamage;
            HighestDamage = highestDamage;
            MonsterName = monsterName;
            MonsterType = monsterType;
            Health = health;
        }
        public void Attack()
        {
            Random rand = new Random();
            damageDealt = rand.Next(LowestDamage, HighestDamage);
            wizard1.health = wizard1.health - damageDealt;
            Console.WriteLine("The {0} attacks! It deals {1} damage!" +
                "\nYour Wizard now has {2} health remaining.", MonsterName, damageDealt, wizard1.health);
            if (wizard1.health <= 0)
            {
                Console.WriteLine("You lose, fool. Your health is all gone." +
                    "\nYou were slain by a {0} and the game is now over.\n\nBad", MonsterName);
                Thread.Sleep(1000);
                Console.WriteLine("Please close the application. You are not very good at this game.");
                while (true)
                {}//leave user in a loop till they shut the app
            }
        }
        public void TakeDamage()
        {
            Console.WriteLine("Now it's your turn! You may attack the {0}.\n" +
                "You may choose of 4 spells, 'earth', 'air', 'water' or 'fire'. \n" +
                "They each do different damage based on which monster they are sent against.\n" +
                "Press the corresponding button to which spell you mean to use!\n", MonsterName);
            spell = Convert.ToInt32(Console.ReadLine());
            switch (MonsterType)
            {
                case "Earth":
                    getSpell(2, 3, 1, 4);
                    break;
                case "Air":
                    getSpell(4,3,1,2);
                    break;
                case "Water":
                    getSpell(1, 2, 3, 4);
                    break;
                case "Fire":
                    getSpell(3, 4, 1, 2);
                    break;
            }
        }
        public void getSpell(int goodSpell, int badSpell1, int badSpell2, int badSpell3)
        {
            while (true)
            {

                if (spell == goodSpell)
                {
                    damageTaken = wizard1.attack * 3;
                    Health -= damageTaken;
                    Console.WriteLine("Nice, this spell does Triple Damage to {0} Monsters!\n" +
                        "You dealt {1} damage to the {2}\n" +
                        "It has {3} health remaining", MonsterType, damageTaken, MonsterName, Health);
                    break;
                }
                if (spell == badSpell1 || spell == badSpell2 || spell == badSpell3)
                {
                    damageTaken = wizard1.attack;
                    Console.WriteLine("Meh, you did ok; this spell does regular damage to {0} Monsters.\n" +
                        "You dealt {1} damage to the {2}", MonsterType, damageTaken, MonsterName);
                    Health -= damageTaken;
                    break;

                }
                else
                {
                    Console.WriteLine("You fool, you entered an invalid value.\n" +
                        " Try again now, you dimwit.\n");
                    continue;
                }
            }
        }
    }
}
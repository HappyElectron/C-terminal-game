using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardGame
{
    public class Monster
    {
        public static TutorialClass tutorial = new TutorialClass();
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
            playerHealth = 10 * wizard1.healthLevel;
            Console.WriteLine(playerHealth + ", " + wizard1.healthLevel);
            Random rand = new Random();
            damageDealt = rand.Next(LowestDamage, HighestDamage);
            playerHealth = playerHealth - damageDealt;
            Console.WriteLine("The {0} attacks! It deals {1} damage!" +
                "\nYour Wizard now has {2} health remaining.", MonsterName, damageDealt, playerHealth);
            if (playerHealth <= 0)
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
                    while (true)
                    {

                        if (spell == 2)
                        {
                            damageTaken = wizard1.attack * 3;
                            Health -= damageTaken;
                            Console.WriteLine("Nice, this spell does Triple Damage to {0} Monsters!\n" +
                                "You dealt {1} damage to the {2}\n" +
                                "It has {3} health remaining", MonsterType, damageTaken, MonsterName, Health);
                            break;
                        }
                        if (spell == 3 || spell == 1 || spell == 4)
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
                    break;
                case "Air":
                    while (true)
                    {

                        if (spell == 4)
                        {
                            damageTaken = wizard1.attack * 3;
                            Console.WriteLine("Nice, this spell does Triple Damage to {0} Monsters!\n" +
                                "You dealt {1} damage to the {2}", MonsterType, damageTaken, MonsterName);
                            Health -= damageTaken;

                        }
                        if (spell == 3 || spell == 1 || spell == 2)
                        {
                            damageTaken = wizard1.attack;
                            Console.WriteLine("Meh, you did ok; this spell does regular damage to {0} Monsters.\n" +
                                "You dealt {1} damage to the {2}", MonsterType, damageTaken, MonsterName);
                            Health -= damageTaken;

                        }
                        else
                        {
                            Console.WriteLine("You fool, you entered an invalid value.\n" +
                                " Try again now, you dimwit.\n");
                            continue;
                        }
                        break;
                    }
                    break;
                case "Water":
                    while (true)
                    {

                        if (spell == 1)
                        {
                            damageTaken = wizard1.attack * 3;
                            Console.WriteLine("Nice, this spell does Triple Damage to {0} Monsters!\n" +
                                "You dealt {1} damage to the {2}", MonsterType, damageTaken, MonsterName);
                            Health -= damageTaken;

                        }
                        if (spell == 3 || spell == 4 || spell == 2)
                        {
                            damageTaken = wizard1.attack;
                            Console.WriteLine("Meh, you did ok; this spell does regular damage to {0} Monsters.\n" +
                                "You dealt {1} damage to the {2}", MonsterType, damageTaken, MonsterName);
                            Health -= damageTaken;

                        }
                        else
                        {
                            Console.WriteLine("You fool, you entered an invalid value.\n" +
                                " Try again now, you dimwit.\n");
                            continue;
                        }
                        break;
                    }
                    break;
                case "Fire":
                    while (true)
                    {

                        if (spell == 3)
                        {
                            damageTaken = wizard1.attack * 3;
                            Console.WriteLine("Nice, this spell does Triple Damage to {0} Monsters!\n" +
                                "You dealt {1} damage to the {2}", MonsterType, damageTaken, MonsterName);
                            Health -= damageTaken;

                        }
                        if (spell == 4 || spell == 1 || spell == 2)
                        {
                            damageTaken = wizard1.attack;
                            Console.WriteLine("Meh, you did ok; this spell does regular damage to {0} Monsters.\n" +
                                "You dealt {1} damage to the {2}", MonsterType, damageTaken, MonsterName);
                            Health -= damageTaken;

                        }
                        else
                        {
                            Console.WriteLine("You fool, you entered an invalid value.\n" +
                                " Try again now, you dimwit.\n");
                            continue;
                        }
                        break;
                    }
                    break;
            }
        }
    }
}
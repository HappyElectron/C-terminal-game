using System;

namespace WizardGame
{
    public class CreateMonsters
    {
        public static int whichMonster;
        static TutorialClass tutorial = Program.tutorial;
        static Wizard wizard1 = tutorial.wizard1;
        public string monsterType;
        public void Combat(Monster monster)
        {
            Console.WriteLine("\n\nYou are approached by a {0}, and it means to attack you!\n", monster.MonsterName);
            while (monster.Health > 0 && wizard1.health > 0)
            {
                Random rand = new Random();
                monster.Attack();
                monster.TakeDamage();
                if (monster.Health <= 0)
                {
                    Console.WriteLine("\nYour Health has been reset.");
                    wizard1.health = wizard1.maxHealth;
                    wizard1.xp += rand.Next(monster.LowestXp, monster.HighestXp);
                    if (wizard1.xp > 6 * wizard1.level)
                    {
                        wizard1.level++;
                    }
                }
            }
        }
        public void createMonsters_InitializeCombat(int lowerMonster, int upperMonster)
        {
            Monster goblin = new Monster(wizard1, 1, 5, 1, 3, "Goblin", "Earth", 3);
            Monster bigAngryBird = new Monster(wizard1, 3, 7, 3, 7, "Big Angry Bird", "Air", 7);
            Monster seaSerpent = new Monster(wizard1, 5, 10, 5, 7, "Sea Serpent", "Water", 15);
            Monster dragon = new Monster(wizard1, 10, 20, 10, 20, "Dragon", "Fire", 30);
            Random rand = new Random();
            whichMonster = rand.Next(lowerMonster, upperMonster);
            switch (whichMonster)
            {
                case 1:
                    Combat(goblin);
                    break;
                case 2:
                    Combat(bigAngryBird);
                    break;
                case 3:
                    Combat(seaSerpent);
                    break;
                case 4:
                    Combat(dragon);
                    break;
            }
            Console.WriteLine("Yowza! You beat the monster! it has no more health. \n" +
                "You're pretty groovy!");
        }
    }
}
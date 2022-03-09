using System;

namespace WizardGame
{
    public class CreateMonsters
    {
        public static int whichMonster;
        static TutorialClass tutorial = Program.tutorial;
        static Wizard wizard1 = tutorial.wizard1;
        public void createMonsters_InitializeCombat(int lowerMonster, int upperMonster)
        {
            Monster goblin = new Monster(wizard1, 1, 5, 1, 3, "Goblin", "Earth", 3);
            Monster bigAngryBird = new Monster(wizard1, 5, 10, 3, 7, "Big Angry Bird", "Air", 7);
            Monster seaSerpent = new Monster(wizard1, 7, 10, 5, 7, "Sea Serpent", "Water", 15);
            Monster dragon = new Monster(wizard1, 20, 40, 10, 20, "Dragon", "Fire", 30);
            Random rand = new Random();
            whichMonster = rand.Next(lowerMonster, upperMonster);
            Console.WriteLine("You are approached by a {0}, and it means to attack you!\n" +
                "(goblin = 1, Big angry bird = 2, sea serpent = 3 dragon = 4\n",whichMonster);
            switch (whichMonster)
            {
                case 1:
                    while (goblin.Health > 0 && wizard1.health > 0)
                    {
                        goblin.Attack();
                        goblin.TakeDamage();
                        if(goblin.Health <= 0)
                        {
                            wizard1.xp += rand.Next(goblin.LowestXp, goblin.HighestXp);
                            if(wizard1.xp > 4*wizard1.level)
                            {
                                wizard1.level++;
                            }
                        }
                    }
                    break;
                case 2:
                    while (bigAngryBird.Health > 0 && wizard1.health > 0)
                    {
                        bigAngryBird.Attack();
                        bigAngryBird.TakeDamage();
                        if (bigAngryBird.Health <= 0)
                        {
                            wizard1.xp += rand.Next(bigAngryBird.LowestXp, bigAngryBird.HighestXp);
                            if (wizard1.xp > 4 * wizard1.level)
                            {
                                wizard1.level++;
                            }
                        }
                    }
                    break;
                case 3:
                    while (seaSerpent.Health > 0 && wizard1.health > 0)
                    {
                        seaSerpent.Attack();
                        seaSerpent.TakeDamage();
                        if (seaSerpent.Health <= 0)
                        {
                            wizard1.xp += rand.Next(seaSerpent.LowestXp, seaSerpent.HighestXp);
                            if (wizard1.xp > 4 * wizard1.level)
                            {
                                wizard1.level++;
                            }
                        }
                    }
                    break;
                case 4:
                    while (dragon.Health > 0 && wizard1.health > 0)
                    {
                        dragon.Attack();
                        dragon.TakeDamage();
                        if (dragon.Health <= 0)
                        {
                            wizard1.xp += rand.Next(dragon.LowestXp, dragon.HighestXp);
                            if (wizard1.xp > 4 * wizard1.level)
                            {
                                wizard1.level++;
                            }
                        }
                    }
                    break;
            }
            Console.WriteLine("Yowza! You beat the monster! it has no more health. \n" +
                "You're pretty groovy!");
        }
    }
}
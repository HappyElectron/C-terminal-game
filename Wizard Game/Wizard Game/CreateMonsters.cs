using System;

namespace WizardGame
{
    public class CreateMonsters
    {
        public static int whichMonster;
        static TutorialClass tutorial = Program.tutorial;
        static Wizard wizard1 = tutorial.wizard1;
        public string monsterType;
        public int xpGained;
        public int xpReq;
        public int xpReqLvl;
        public int nextLevel;
        public void Combat(Monster monster)
        {
            switch (wizard1.level)
            {
                case 1:
                    xpReq = 10;
                    break;
                case 2:
                    xpReq = 30;
                    break;
                case 3:
                    xpReq = 70;
                    break;
                case 4:
                    xpReq = 120;
                    break;
            }
            Console.WriteLine("\n\nYou are approached by a {0}, and it means to attack you!\n", monster.MonsterName);
            wizard1.health = wizard1.healthLevel * 10;
            while (monster.Health > 0 && wizard1.health > 0)
            {
                Random rand = new Random();
                monster.Attack();
                monster.TakeDamage();
                if (monster.Health <= 0)
                {
                    Console.WriteLine("\nYour Health has been reset.");
                    wizard1.health = 10 * wizard1.healthLevel;
                    xpGained = rand.Next(monster.LowestXp, monster.HighestXp);
                    wizard1.xp += xpGained;
                    if (wizard1.xp > xpReq)
                    {
                        wizard1.level++;
                        Console.WriteLine("Congratulations! " + wizard1.name + " has levelled up to level " + wizard1.level + "!\nYou may now choose a skill to level up!");
                        wizard1.IncreaseStats();
                        switch (wizard1.level)
                        {
                            case 1:
                                xpReq = 10;
                                break;
                            case 2:
                                xpReq = 50;
                                break;
                            case 3:
                                xpReq = 70;
                                break;
                            case 4:
                                xpReq = 120;
                                break;
                        }
                    }
                }
            }
        }
        public void createMonsters_InitializeCombat(int lowerMonster, int upperMonster)
        {
            Monster goblin = new Monster(1, 5, 1, 3, "Goblin", "Earth", 3);
            Monster bigAngryBird = new Monster(3, 7, 3, 7, "Big Angry Bird", "Air", 7);
            Monster seaSerpent = new Monster(5, 10, 5, 7, "Sea Serpent", "Water", 15);
            Monster dragon = new Monster(10, 20, 10, 20, "Dragon", "Fire", 30);
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
            xpReqLvl = xpReq - wizard1.xp;
            nextLevel = wizard1.level + 1;
            Console.WriteLine("Yowza! You beat the monster!\nYou received " + xpGained + " experience from the monster.\nThis means " + wizard1.name + " needs " + xpReqLvl + " experience to get to level " + nextLevel + ".\nPress any button to fight the next enemy:");
            Console.ReadLine();
        }
    }
}
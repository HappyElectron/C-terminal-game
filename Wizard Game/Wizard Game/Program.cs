using System;

namespace WizardGame
{
    class Program
    {
        public static int whichMonster;
        static void Main(string[] args)
        {
            TutorialClass tutorial = new TutorialClass();
            tutorial.Tutorial();
            Wizard wizard1 = tutorial.wizard1;
            while(wizard1.level == 1)
            {
                Monster goblin = new Monster(wizard1,1,5,1,3,"Goblin","Earth", 3);
                Console.WriteLine("boop");//test
                while (goblin.Health >= 1 && wizard1.health >= 1)//test function
                {
                    Console.WriteLine("boop2");
                    goblin.Attack();
                    goblin.TakeDamage();
                }
            }
            while(wizard1.level == 2)
            {
                Monster goblin = new Monster(wizard1, 1, 5, 1, 3, "Goblin", "Earth", 3);
                Monster bigAngryBird = new Monster(wizard1, 5, 10, 3, 7, "Big Angry Bird", "Air", 7);
                Random rand = new Random();
                whichMonster = rand.Next(1, 2);
                switch (whichMonster)
                {
                    case 1:
                        while(goblin.Health > 0 && wizard1.health > 0)
                        {
                            goblin.Attack();
                            goblin.TakeDamage();
                        }
                        break;
                    case 2:
                        while (bigAngryBird.Health > 0 && wizard1.health > 0)
                        {
                            bigAngryBird.Attack();
                            bigAngryBird.TakeDamage();
                        }
                        break;
                }
            }
            while (wizard1.level == 3)
            {
                Monster goblin = new Monster(wizard1, 1, 5, 1, 3, "Goblin", "Earth", 3);
                Monster bigAngryBird = new Monster(wizard1, 5, 10, 3, 7, "Big Angry Bird", "Air", 7);
                Monster seaSerpent = new Monster(wizard1, 10, 20, 7, 15, "Sea Serpent", "Water", 15);
                Random rand = new Random();
                whichMonster = rand.Next(1, 3);
                switch (whichMonster)
                {
                    case 1:
                        while (goblin.Health > 0 && wizard1.health > 0)
                        {
                            goblin.Attack();
                            goblin.TakeDamage();
                        }
                        break;
                    case 2:
                        while (bigAngryBird.Health > 0 && wizard1.health > 0)
                        {
                            bigAngryBird.Attack();
                            bigAngryBird.TakeDamage();
                        }
                        break;
                    case 3:
                        while (seaSerpent.Health > 0 && wizard1.health > 0)
                        {
                            seaSerpent.Attack();
                            seaSerpent.TakeDamage();
                        }
                        break;
                }
            }
            while (wizard1.level == 4)
            {
                Monster goblin = new Monster(wizard1, 1, 5, 1, 3, "Goblin", "Earth", 3);
                Monster bigAngryBird = new Monster(wizard1, 5, 10, 3, 7, "Big Angry Bird", "Air", 7);
                Monster seaSerpent = new Monster(wizard1, 7, 10, 5, 7, "Sea Serpent", "Water", 15);
                Monster dragon = new Monster(wizard1, 20, 40, 10, 20, "Dragon", "Fire", 30);
                Random rand = new Random();
                whichMonster = rand.Next(1, 3);
                switch (whichMonster)
                {
                    case 1:
                        while (goblin.Health > 0 && wizard1.health > 0)
                        {
                            goblin.Attack();
                            goblin.TakeDamage();
                        }
                        break;
                    case 2:
                        while (bigAngryBird.Health > 0 && wizard1.health > 0)
                        {
                            bigAngryBird.Attack();
                            bigAngryBird.TakeDamage();
                        }
                        break;
                    case 3:
                        while (seaSerpent.Health > 0 && wizard1.health > 0)
                        {
                            seaSerpent.Attack();
                            seaSerpent.TakeDamage();
                        }
                        break;
                    case 4:
                        while (dragon.Health > 0 && wizard1.health > 0)
                        {
                            dragon.Attack();
                            dragon.TakeDamage();
                        }
                        break;
                }
            }
        }
    }
}

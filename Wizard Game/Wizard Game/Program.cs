using System;

namespace WizardGame
{
    class Program
    {
        public static TutorialClass tutorial = new TutorialClass();
        public static Wizard wizard1 = tutorial.wizard1;
        static void Main(string[] args)
        {
            tutorial.Tutorial();
            while (wizard1.level == 1)
            {
                CreateMonsters createMonsters = new CreateMonsters();
                createMonsters.createMonsters_InitializeCombat(1,1);
            }
            Console.WriteLine("Nice! You leveled up. You are now level 2.");
            wizard1.IncreaseStats();
            while(wizard1.level == 2)
            {
                CreateMonsters createMonsters = new CreateMonsters();
                createMonsters.createMonsters_InitializeCombat(1, 2);
            }
            Console.WriteLine("Nice! You leveled up. You are now level 3.");
            wizard1.IncreaseStats();
            while (wizard1.level == 3)
            {
                CreateMonsters createMonsters = new CreateMonsters();
                createMonsters.createMonsters_InitializeCombat(1, 3);
            }
            Console.WriteLine("Nice! You leveled up. You are now level 4.");
            wizard1.IncreaseStats();
            while (wizard1.level == 4)
            {
                CreateMonsters createMonsters = new CreateMonsters();
                createMonsters.createMonsters_InitializeCombat(1, 4);
            }
            EndGame endGame = new EndGame();
            endGame.function();
        }
    }
}

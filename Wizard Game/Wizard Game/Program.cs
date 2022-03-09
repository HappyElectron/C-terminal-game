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
            while(wizard1.level == 2)
            {
                CreateMonsters createMonsters = new CreateMonsters();
                createMonsters.createMonsters_InitializeCombat(1, 2);
            }
            while (wizard1.level == 3)
            {
                CreateMonsters createMonsters = new CreateMonsters();
                createMonsters.createMonsters_InitializeCombat(1, 3);
            }
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

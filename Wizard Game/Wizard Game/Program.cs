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
            while (true)
            {
                CreateMonsters createMonsters = new CreateMonsters();
                createMonsters.createMonsters_InitializeCombat();
                if (wizard1.level > 4)
                {
                    EndGame endgame = new EndGame();
                    endgame.function();
                }
            }
        }
    }
}

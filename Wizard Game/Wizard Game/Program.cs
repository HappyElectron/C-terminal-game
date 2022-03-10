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
            for(int i = 1; i <= 4; i++)
            {
                while (wizard1.level == i)
                {
                    CreateMonsters createMonsters = new CreateMonsters();
                    createMonsters.createMonsters_InitializeCombat(1, i);
                }
            }
        }
    }
}

using System;

namespace WizardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TutorialClass tutorial = new TutorialClass();
            tutorial.Tutorial();
            Wizard wizard1 = tutorial.wizard1;
            for (int i = 1; i <= 5; i++)
            {
                while(wizard1.level == i)
                {

                }
            }
        }
    }
}

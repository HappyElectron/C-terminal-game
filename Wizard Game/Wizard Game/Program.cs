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
            while(wizard1.level == 1)
            {
                Monster goblin = new Monster(wizard1,1,5,1,3,"Goblin","Earth");
                goblin.Attack();//test function
            }
            {
                Monster goblin = new Monster(wizard1, 1, 5, 1, 3, "Goblin", "Earth");
                Monster bigAngryBird = new Monster(wizard1, 5, 10, 3, 7, "Big Angry Bird", "Air");
            }
            while (wizard1.level == 3)
            {
                Monster goblin = new Monster(wizard1, 1, 5, 1, 3, "Goblin", "Earth");
                Monster bigAngryBird = new Monster(wizard1, 5, 10, 3, 7, "Big Angry Bird", "Air");
                Monster seaSerpent = new Monster(wizard1, 10, 20, 7, 15, "Sea Serpent", "Water");
            }
            while (wizard1.level == 4)
            {
                Monster goblin = new Monster(wizard1, 1, 5, 1, 3, "Goblin", "Earth");
                Monster bigAngryBird = new Monster(wizard1, 5, 10, 3, 7, "Big Angry Bird", "Air");
                Monster seaSerpent = new Monster(wizard1, 7, 10, 5, 7, "Sea Serpent", "Water");
                Monster dragon = new Monster(wizard1, 20, 40, 10, 20, "Dragon", "Fire");
            }
        }
    }
}

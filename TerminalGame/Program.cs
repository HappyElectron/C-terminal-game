using System;
namespace WizardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Setup();
            Console.WriteLine("Now, {0}, you will begin You trials! Monsters will come, at either level 1, 2, or 3. \nEach monster will give 'xp' depending on what level they are.", user.Name);
            while (user.Xp < 100)
            {
            }
        }
    }
}

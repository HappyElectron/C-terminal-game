using System;

namespace WizardGame
{
    public class EndGame
    {
        public void function()
        {
            Console.Clear();
            Console.WriteLine("Well done, you have finished your journey! \n" +
                "Thanks for playing!");
            Console.Clear();
            Thread.Sleep(1500);
            Console.WriteLine("...");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("the game is never really over... Kodie");
            while (true) { }
            
            
            
        }
    }
}

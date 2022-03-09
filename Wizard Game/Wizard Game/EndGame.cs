using System;

namespace WizardGame
{
    public class EndGame
    {
        public void function()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("\n");
            }
            Console.WriteLine("Well done, you have finished your journey in the wizard of OZ\n" +
                "Thanks for playing!\n\n\n");
            Thread.Sleep(2000);
            Console.WriteLine("...");
            Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("the game is never really over... Kodie");
            while (true) { }
            
        }
    }
}

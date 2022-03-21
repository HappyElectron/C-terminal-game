using System;

namespace WizardGame
{
    public class EndGame
    {
        public string goodbye = "Well done, you have beaten the game!\n " +
            "Thanks for playing!";
        public int c;
        public void function()
        {
            Console.Clear();
            Console.Out.NewLine = "";
            foreach (char character in goodbye)
            {
                Random rand = new Random();
                c = rand.Next(0, 7);
                switch (c)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                }
                Console.WriteLine(Convert.ToString(character));
            }
            Console.Out.NewLine = "\r\n";
            Thread.Sleep(1500);
            Console.WriteLine("\n...");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nThe game is never really over... Kodie");
            while (true) { }
            
        }
    }
}

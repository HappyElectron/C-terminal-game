using System;

namespace Print_Array
{
 
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Play play1 = new Play();
                play1.PlayGame();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("Would you like to play again?");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Y");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("N?\n");
                Console.ForegroundColor = ConsoleColor.Black;
                

            } while (Console.ReadLine().ToLower() == "y");

        }

    }

    public class Play
    {
        public void PlayGame()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter 3 Numbers between 1-10, if any match my number, you win!\n");
            Console.ForegroundColor = ConsoleColor.Black;
            int[] numbers = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Random x = new Random();
            int randNum = x.Next(1, 11);
            while (numbers[0] == randNum || numbers[1] == randNum || numbers[2] == randNum)
            {
                randNum = x.Next(1, 11);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("My number was... {0}", randNum);
        }
    }
}
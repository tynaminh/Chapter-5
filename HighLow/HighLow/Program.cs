using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            int userEntry;
            bool again = true;
            int guesses = 0;
            while (again)
            {
                Console.WriteLine("Please enter a number 1 - 100!");
                userEntry = Convert.ToInt32(Console.ReadLine());
                if (userEntry > r)
                {
                    Console.WriteLine("Hey buddy that number is too high!!");
                }
                else if (userEntry < r)
                {
                    Console.WriteLine("Hey pal that number is two low!");
                }
                else if (userEntry == r)
                {
                    Console.WriteLine("Good job, friend. You've guessed right!!");
                }
                guesses = guesses + 1;
                if (guesses == 6)
                {
                    Console.WriteLine("Stop playing the game = " + guesses +
                        "\n answer was " + r);
                    again = false;
                }
            }
        }
    }
}


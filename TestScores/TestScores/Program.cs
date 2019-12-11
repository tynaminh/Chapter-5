using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;

            Console.WriteLine("Enter a number 0-100");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == 0)
            {
                Console.WriteLine("Congrats!!");
            }
            else if (userEntry != 100)
            {
                Console.WriteLine("That's wrong dummy");
            }

        }
    }
}

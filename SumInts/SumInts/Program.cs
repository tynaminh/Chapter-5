using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry;
            int total = 0;
            do
            {
                Console.WriteLine("Pick a number!! >>>");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;

            } while (entry !=999);
            Console.WriteLine(total );
        }
    }
}

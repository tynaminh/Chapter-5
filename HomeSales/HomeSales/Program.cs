using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEntry;
            int totalD = 0;
            int salesEntry;
            int totalE = 0;
            int totalF = 0;
            int total;
            bool again = true;
            while (again)
            {
                Console.WriteLine("Please enter your sales host's initial. >>>");
                userEntry = Console.ReadLine();
                if (userEntry == "D")
                {
                    Console.WriteLine("Enter sales for D");
                    salesEntry = Convert.ToInt32(Console.ReadLine());
                    totalD = totalD + salesEntry;
                }
                else if (userEntry == "E")
                {
                    Console.WriteLine("Enter sales for E");
                    salesEntry = Convert.ToInt32(Console.ReadLine());
                    totalE = totalE + salesEntry;
                }
                else if (userEntry == "F")
                {
                    Console.WriteLine("Enter sales for F");
                    salesEntry = Convert.ToInt32(Console.ReadLine());
                    totalF = totalF + salesEntry;
                }
            }
            total = totalD + totalE + totalF;
        }
    }
}

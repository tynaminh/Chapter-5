using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            displayForLoops();
            
        }
        public static void displayForLoops()
        {
            for (int i = 10; i >= 0; --i)
            {
                Console.WriteLine(i);
            }
            for (int j = 10;j >=0; --j)
            {
                Console.WriteLine(j);
            }
        }
        public static void displayDoWhileLoop()
        {
            int count = 0;
            string response = null;


            do {
                do
                {

                    Console.WriteLine(count);
                    count++;
                } while (count < 10);
                count = 10;
                do
                {
                    Console.WriteLine(count);
                    count--;
                } while (count > 0);
                Console.WriteLine("Would you like to count again? Y or N");
                response = Console.ReadLine();

            } while ("Y" != response);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidID
{
    class Program
    {
        static void Main(string[] args)
        {
            displayValidID();
        }
        public static void displayValidID()
        {
            int idNum;
            string input;
            const int LOW = 1000;
            const int HIGH = 9999;

            Console.WriteLine("Enter an ID Number");
            input = Console.ReadLine();
            idNum = Convert.ToInt32(input);

            while (idNum < LOW || idNum > HIGH)
            {
                Console.WriteLine("{0} is an invaild ID number", idNum);
                Console.Write("ID numbers must be ");
                Console.WriteLine("between {0} and {1} inculusive", LOW, HIGH);
                Console.Write("Enter an ID Number);
                input = Console.ReadLine();
                idNum = Convert.ToInt32(input);
            }
            Console.WriteLine("ID number {0} is valid", idNum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterLowercaseLetter
{
    class Program
    {
        static void Main(string[] args)
        {
           char userEntry;

            Console.WriteLine("Please enter a lowercase letter. >>>" );
            userEntry = Console.ReadKey().KeyChar;

            if (userEntry != 'A')
            {
                Console.WriteLine(" Okay, your letter " + userEntry + " is lowercase " );
            }
            else if (userEntry != 'a')
            {
                Console.WriteLine(" Uh oh, your letter " + userEntry + " is not lowercase! " );
            }
        }
    }
}

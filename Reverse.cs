using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Reverse
    {
        public static void ReverseF(int number)
        {
            int remainder = 0, reverse = 0;
            Console.WriteLine(number); //1234
            
            while (number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10)+remainder;
                number = number / 10;
                Console.WriteLine("Last digit:{0}", remainder);
                Console.WriteLine("Number:{0}", number);
                Console.WriteLine("Reverse:{0}", reverse);
            }
            Console.WriteLine("After reverse:{0}", reverse);
        }
    }
}

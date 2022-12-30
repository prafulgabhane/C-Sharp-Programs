using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Table
    {
        public static void TableF()
        {
            Console.WriteLine("Enter Any digit");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            Console.WriteLine(" Table for {0}",num);
            for (i = 1; i <= 10; i++) 
            {
                Console.Write(" {0} X {1} = {2}\n",num,i,i*num);
            }
            Console.WriteLine(" Done");
        }

    }
}

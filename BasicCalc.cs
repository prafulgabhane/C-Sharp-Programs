using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BasicCalc
    {
        public static void CalcF()
        {
            Console.WriteLine("Select Operations");
            Console.WriteLine("1:Add\n2:Sub\n3:Div\n4:Multi");
            int CaseSelector = Convert.ToInt32(Console.ReadLine());
           
          //Input
            Console.WriteLine("Enter First Number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int n2 = Convert.ToInt32(Console.ReadLine());

            switch (CaseSelector)
            {
                case 1:
                    Console.WriteLine("Addition: {0}", n1 + n2);
                    break;
                case 2:
                    Console.WriteLine("Subtraction: {0}", n1 - n2);
                    break;
                case 3:
                    Console.WriteLine("Division: {0}", n1 / n2);
                    break;
                case 4:
                    Console.WriteLine("Multiplication: {0}", n1 * n2);
                    break;
                
            }
            Console.WriteLine("done");
        }
    }
}

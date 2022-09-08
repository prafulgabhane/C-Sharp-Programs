using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to console");
            
            Console.WriteLine("Choose any Program");
            Console.WriteLine("1:Sum\n2:Reverse\n3:Table\n4:Sum of Digits\n5:Basic Calculator");
            int choice = Convert.ToInt32(Console.ReadLine());
            
           
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Sum of two digits");
                        Sum.SumF();
                        break;

                    case 2:
                        Console.WriteLine("Enter any no for Reverse");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Reverse.ReverseF(number);
                        break;

                    case 3:
                        Table.TableF();
                        break;

                    case 4:
                        SumOfDigits.DigitsF();
                        break;

                    case 5:
                        BasicCalc.CalcF();
                        break;

                    default:
                        Console.WriteLine("Enter Between Range");
                        break;
                }
            Console.ReadLine();
          }
    }
}

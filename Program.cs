using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while(!exit)
            {
                try
                {


                    Console.WriteLine("Enter first number:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Second number:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter '+' for addition");
                    Console.WriteLine("Enter '-' for subtraction");
                    Console.WriteLine("Enter '*' for multiplication");
                    Console.WriteLine("Enter '/' for division");
                    Console.WriteLine("Enter 'e or E' to exit");
                    Console.WriteLine("Enter 'c or C' to clear");

                    Char read = Convert.ToChar(Console.ReadLine());
                    if(read=='+')
                    {
                        Console.WriteLine($"Answer:{num1 + num2}");

                    } else if (read == '-')
                    {

                        Console.WriteLine($"Answer:{num1 - num2}");
                    } else if (read=='*')
                    {

                        Console.WriteLine($"Answer:{num1 * num2}");
                    } else if ( read=='/')
                    {

                        Console.WriteLine($"Answer:{num1 / num2}");
                    }else if(read=='C'||read=='c')
                    {
                        Console.Clear();
                    } else if(read=='e'||read =='E')
                    {
                        exit = true;
                    }else
                    {
                        Console.WriteLine("Input is invalid!");
                    }
                }
                catch
                {
                    Console.WriteLine("Input is invalid!");
                }
            }
        }
    }
}

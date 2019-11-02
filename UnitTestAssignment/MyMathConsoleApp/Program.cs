/*Author: Cody Martin
 Class: CTEC 135 Week 5
 Task: Programming Assignment 

 This program tests methods from the respective classes. 

 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("101 + 99 = {0}", MyMath1.Add((byte)101, (byte)99));
            Console.WriteLine();
            Console.WriteLine("101 + 201 = {0}", MyMath1.Add(101,201));

            try
            {
                Console.WriteLine();
                Console.WriteLine("101 + 99 = {0}", MyMath2.Add((byte)101, (byte)99));
                Console.WriteLine();
                Console.WriteLine("101 + 201 = {0}", MyMath2.Add(101, 201));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

        }
    }
}

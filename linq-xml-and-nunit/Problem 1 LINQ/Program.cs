/*Author: Cody Martin
 Class: CTEC 135 Week 5
 Task: Programming Assignment 5

 This program uses LINQ to query an array made in main. It also 
 shows alterations being made to the array and reusing the original query 
 to print out the changes.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating array of strings in random order
            //printing out the original array 

            string[] strArray = { "Hello", "Fred", "Chuck", "Basketball", "Frisbee", "Alex" };
            Console.WriteLine("Original items in array:");
            Console.WriteLine();
            foreach (string n in strArray)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            // creating LINQ query
            // looking for items in the array that start with letters A-F

            var queryResults =
                from n in strArray
                where n.StartsWith("A")  || n.StartsWith("B") || n.StartsWith("C") 
                || n.StartsWith("D") || n.StartsWith("E") || n.StartsWith("F")
                select n;

            // printing results of query 

            Console.WriteLine("Results of query:");
            Console.WriteLine();
            foreach(string s in queryResults)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();

            // changing the value of index 2 - "Chuck" to "Abe"

            strArray[2] = "Abe";

            // Reusing the original query to print out changes to array
            Console.WriteLine("Changes to the array:");
            Console.WriteLine();
            foreach (string s in queryResults)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();

            //changing the array again by index

            strArray[0] = "Chip";
            strArray[1] = "Frank";
            strArray[2] = "Jesse";

            // Reusing the original query to print out changes to array again
            Console.WriteLine("Changes to the array again:");
            Console.WriteLine();
            foreach (string s in queryResults)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();

                                            

            // Creating method immediate execution and returns results to main

            List<string> QueryOverStrings(string[] inputArray)
            {


                List<string> outputList = (from n in inputArray
                                           where n.StartsWith("A") || n.StartsWith("B") || n.StartsWith("C")
                                           || n.StartsWith("D") || n.StartsWith("E") || n.StartsWith("F")
                                           select n).ToList<string>();
               
                return outputList;
            }

            Console.WriteLine();

            // calling the method for immediate execution and assigning the return to "resultEx"

            List<string> resultEx = QueryOverStrings(strArray);

            // printing the result
            Console.WriteLine("The results of the list conversion return:");
            Console.WriteLine();


            foreach (string s in resultEx)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();



        }
    }
}

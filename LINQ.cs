using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 20, 5, 8, 12, 99, 15 };//initialize array with 6 item

            Console.Write("The items in Array \"array\" is: ");
            foreach (var item in array)
            {
                Console.Write($"{item,1}\t");
            }
            Console.WriteLine("");

            var filter =
                from val in array
                where val > 8
                select val;

            Console.Write("The items in Array \"array\" after filtered is: ");
            foreach (var item in filter)
            {
                Console.Write($"{item , 1}\t");
            }
            Console.WriteLine("");

            var order =
                from val in array
                orderby val 
                select val;

            Console.Write("The items in Array \"array\" after order it is: ");
            foreach (var item in order)
            {
                Console.Write($"{item,1}\t");
            }
            Console.WriteLine("");

            var filterOrder =
                from val in array
                where val > 8
                orderby val descending
                select val;

            Console.Write("The items in Array \"array\" after filtered and order it is: ");
            foreach (var item in filterOrder)
            {
                Console.Write($"{item,1}\t");
            }
            Console.WriteLine("");

        }
    }
}

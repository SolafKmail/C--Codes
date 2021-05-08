using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Absolute -3.5 = {Math.Abs(-3.5)}");
            Console.WriteLine($"The squar root of 16 is {Math.Sqrt(16)}");

            Console.WriteLine($"The maximum number between 5 , 6 , 7 is {FindMax.GitMax(5, 6, 7)}");


            Random ran = new Random();

            int random1 = ran.Next();
            int random2 = ran.Next(10);//number between 0 and 10
            int random3 = ran.Next(1,50);//number between 1 and 50

            for (int i = 0; i < 10; i++)
            {
                int random = ran.Next(14);
                Console.Write(random.ToString()+ "\t");//random.ToString(): To convert the integer value to string
            }

        }
    }
}

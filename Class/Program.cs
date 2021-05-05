using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student(123, "Solaf");

            Console.WriteLine(st1);//by default call toString
        }
    }
}

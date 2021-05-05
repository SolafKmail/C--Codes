using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello!!!"); //Print "Hello!!!" with new line
			Console.Write("Hello");//Print the string without new line
			Console.WriteLine("Solaf "+"Kmail");//Concatination


			int x = 5 , y = 10;
			Console.WriteLine($"This equation {x} + {y} = {x+y}");
			string str = Console.ReadLine();//Reading a string
			int i = int.Parse(Console.ReadLine());//reading an integer
			double d = double.Parse(Console.ReadLine());//Reading a double

			/*-----------------------------------------------------------------------------------*/

		}
	}
}

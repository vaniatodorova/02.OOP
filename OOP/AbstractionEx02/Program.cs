using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx02
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = int.Parse(Console.ReadLine());
			do
			{
				string a = Console.ReadLine();
				string b = Console.ReadLine();
				double c = double.Parse(Console.ReadLine());
				if (a == "triangle")
				{
					Triangle triangle = new Triangle(b, c);
					Console.WriteLine("{0}:", triangle.GetName());
					Console.WriteLine("Color: " + b);
					Console.WriteLine($"Size: {c}");
					Console.WriteLine("Area:{0}", triangle.GetArea());
				}
				else if(a == "circle")
				{
					Circle circle = new Circle(b, c);
					Console.WriteLine("{0}:", circle.GetName());
					Console.WriteLine("Color: " + b);
					Console.WriteLine($"Size: {c}");
					Console.WriteLine("Area:{0}", circle.GetArea());
				}
				else if (a == "square")
				{
					Square square = new Square(b, c);
					Console.WriteLine("{0}:", square.GetName());
					Console.WriteLine("Color: " + b);
					Console.WriteLine($"Size: {c}");
					Console.WriteLine("Area:{0}", square.GetArea());
				}
				else
				{
					Console.WriteLine("Error");
				}
				i--;
			} while (i>0);
		}
	}
}

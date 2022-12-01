using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx03
{
	public class Seat : ICar
	{
		public string Model { get; private set; }
		public string Color { get; private set; }
		public Seat(string model, string color)
		{
			Console.WriteLine($"{model} Seat {color}");
			Console.WriteLine(Start());
			Console.WriteLine(Stop());
		}
		public string Start()
		{
			return "Engine start";
		}
		public string Stop()
		{
			return "Breaaak!";
		}
	}
}

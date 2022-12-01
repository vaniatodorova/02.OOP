using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx03
{
	public class Tesla : ICar, IElectricCar
	{
		public string Model { get; private set; }
		public string Color { get; private set; }
		public int Batteries { get; private set; }
		public Tesla(string model, string color, int batteries)
		{
			Console.WriteLine($"{color} Tesla {model} with {batteries} Batteries");
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

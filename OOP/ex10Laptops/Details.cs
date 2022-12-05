using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10Laptops
{
	abstract class Details
	{
		public const string name = "Default";
		public string Name { get; }
		public const string price = "Default";
		public string Price { get; }
		public const string processor = "Default";
		public string Processor { get; }
		public const string ram = "Default";
		public string Ram { get; }
		public const string hdd = "Default";
		public string Hdd { get; }
		public Details(string name, string price, string processor, string ram, string hdd)
		{
			Name = name; Price = price; Processor = processor; Ram = ram; Hdd = hdd;
		}
		public void ShowDetails()
		{
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"Price: {Price}");
			Console.WriteLine($"Processor: {Processor}");
			Console.WriteLine($"RAM: {Ram}");
			Console.WriteLine($"HDD: {Hdd}");
		}
	}
}

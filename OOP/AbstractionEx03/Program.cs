using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx03
{
	class Program
	{
		static void Main(string[] args)
		{
			ICar seat = new Seat("Leon", "Grey");
			ICar tesla = new Tesla("Model 3", "Red", 2);
			seat.ToString();
			tesla.ToString();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10Laptops
{
	class Dell : Details
	{
		public Dell(string Name, string Price, string Processor, string Ram, string Hdd) : base(Name, Price, Processor, Ram, Hdd) { }
	}
}

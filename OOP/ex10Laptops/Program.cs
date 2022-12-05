using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10Laptops
{
	class Program
	{
		static void Main(string[] args)
		{
			Lenovo laptop1 = new Lenovo("Lenovo", "$1000","i3","2GB","500GB");
			laptop1.ShowDetails();
			Console.WriteLine("----------");
			Dell laptop2 = new Dell("Dell", "$1500", "i5", "4GB", "1TB");
			laptop2.ShowDetails();
			Console.WriteLine("----------");
			Sony laptop3 = new Sony("Sony", "$2000", "i9", "8GB", "1TB");
			laptop3.ShowDetails();
			Console.WriteLine("----------");
		}
	}
}

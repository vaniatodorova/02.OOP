using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx02
{
	abstract class ColoredFigure
	{
		private string color;
		private double size;
		public ColoredFigure(string color, double size)
		{
			Color = color;
			Size = size;
		}
		public string Color
		{
			get { return color; }
			set { this.color = value; }
		}
		public double Size
		{
			get { return size; }
			set { this.size = value; }
		}
		public abstract string GetName();
		public abstract double GetArea();

		public void Show(string color, double size)
		{
			this.color = Color;
			this.size = Size;
		}
	}
}

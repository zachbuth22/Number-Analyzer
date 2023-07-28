using System;
namespace Circle_Lab
{
	public class Circle
	{
		//properties
		private double Radius { get; set; }

		//constructor
		public Circle(double _radius)
		{
			Radius = _radius;
		}

		//methods
		public double CalculateDiameter()
		{
			return Radius * 2;
		}
		public double CalculateCircumference()
		{
			return 2 * Math.PI * Radius;
		}
		public double CalculateArea()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}
		public void Grow()
		{
			Radius *= 2;
		}
		public double GetRadius()
		{
			return Radius;
		}
	}
}


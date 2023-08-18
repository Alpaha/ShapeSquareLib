using ShapeSquareLib.Shapes.Implementations.Abstractions;

namespace ShapeSquareLib.Shapes.Implementations
{
	public class Circle : Shape
	{
		private double _radius;

		public Circle()
		{
			Name = "Круг";
		}

		public Circle(double radius) : this()
		{
			Radius = radius;
		}

		public double Radius
		{
			get { return _radius; }
			set
			{
				if (value <= 0)
					throw new ArgumentException("Радиус круга не может быть меньше или равен 0");
				_radius = value;
			}
		}

		public override double GetSquare()
		{
			return Math.PI * (Radius * Radius);
		}
	}
}

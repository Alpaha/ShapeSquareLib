using ShapeSquareLib.Shapes.Implementations.Abstractions;

namespace ShapeSquareLib.Shapes.Implementations
{
	public class Triangle : Shape
	{
		private double _a;
		private double _b;
		private double _c;
		private double _h;

		public Triangle()
		{
			Name = "Треугольник";
		}

		/// <summary>
		/// Создать треугольник
		/// </summary>
		/// <param name="a">Сторона треугольника не равная 0</param>
		/// <param name="b">Сторона треугольника не равная 0</param>
		/// <param name="c">Сторона треугольника не равная 0</param>
		public Triangle(double a, double b, double c) : this()
		{
			A = a;
			B = b;
			C = c;
		}

		/// <summary>
		/// Создать треугольник
		/// </summary>
		/// <param name="a">Длина основания</param>
		/// <param name="h">Высота проведённая к стороне a</param>
		public Triangle(double a, double h) : this()
		{
			A = a;
			H = h;
		}

		public double A
		{
			get => _a;
			set
			{
				if (value <= 0)
					throw new ArgumentException("Сторона не может быть меньше или равна 0");

				_a = value;
			}
		}

		public double B
		{
			get => _b;
			set
			{
				if (value <= 0)
					throw new ArgumentException("Сторона не может быть меньше или равна 0");

				_b = value;
			}
		}

		public double C
		{
			get => _c;
			set
			{
				if (value <= 0)
					throw new ArgumentException("Сторона не может быть меньше или равна 0");

				_c = value;
			}
		}

		public double H
		{
			get => _h;
			set
			{
				if (value <= 0)
					throw new ArgumentException("Высота не может быть меньше или равна 0");

				_h = value;
			}
		}

		public override double GetSquare()
		{
			if (IsRightTriangle())
			{
				return GetRightSquare();
			}
			else
				return GetSquareInternal();
		}

		private double GetSquareInternal()
		{
			// Если не была задана высота, считаем по формуле Герона
			if (H == 0)
			{
				var halfP = (A + B + C) / 2;

				return Math.Sqrt(halfP * (halfP - A) * (halfP - B) * (halfP - C));
			}
			else
			{
				return A * H / 2;
			}
		}

		private double GetRightSquare()
		{
			if (A > B && A > C)
				return B * C / 2;

			else if (B > A && B > C)
				return A * C / 2;

			else
				return A * B / 2;
		}

		private bool IsRightTriangle()
		{
			if (A > B && A > C)
			{
				return A * A == B * B + C * C;
			}
			else if (B > A && B > C)
			{
				return B * B == C * C + A * A;
			}
			else
			{
				return C * C == B * B + A * A;
			}
		}
	}
}

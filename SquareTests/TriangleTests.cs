using ShapeSquareLib.Shapes.Implementations;
using ShapeSquareLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareTests
{
	public class TriangleTests
	{
		[Test]
		public void TestZeroSides()
		{
			Assert.Multiple(() =>
			{
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { A = 0 }), Throws.ArgumentException);
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { B = 0 }), Throws.ArgumentException);
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { C = 0 }), Throws.ArgumentException);
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { H = 0 }), Throws.ArgumentException);
			});
		}

		[Test]
		public void TestNegativeSides()
		{
			Assert.Multiple(() =>
			{
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { A = -1 }), Throws.ArgumentException);
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { B = -1 }), Throws.ArgumentException);
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { C = -1 }), Throws.ArgumentException);
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { H = -1 }), Throws.ArgumentException);
			});
		}

		[Test]
		public void TestPositiveSides()
		{
			Assert.Multiple(() =>
			{
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { A = 1 }), Throws.Nothing);
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { B = 1 }), Throws.Nothing);
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { C = 1 }), Throws.Nothing);
				Assert.That(() => SquareCalculator.GetSquare(new Triangle { H = 1 }), Throws.Nothing);
			});
		}

		[Test]
		public void TestRightTriangleSquare()
		{
			var rightTriangle = new Triangle(5, 4, 3);

			Assert.That(SquareCalculator.GetSquare(rightTriangle), Is.EqualTo(6));
		}

		[Test]
		public void TestTriangleSquareBySides()
		{
			var triangle = new Triangle(30, 28, 26);

			Assert.That(SquareCalculator.GetSquare(triangle), Is.EqualTo(336));
		}
	}
}

using ShapeSquareLib;
using ShapeSquareLib.Shapes.Implementations;

namespace SquareTests
{
	public class CircleTests
	{
		[Test]
		public void TestZeroRadius()
		{
			Assert.That(() => SquareCalculator.GetSquare(new Circle(0)), Throws.ArgumentException);
		}

		[Test]
		public void TestNegativeRadius()
		{
			Assert.That(() => SquareCalculator.GetSquare(new Circle(-1)), Throws.ArgumentException);
		}

		[Test]
		public void TestPositiveRadius()
		{
			Assert.That(() => SquareCalculator.GetSquare(new Circle (1)), Throws.Nothing);
		}

		[Test]
		public void TestCircleSquare()
		{
			var circle = new Circle { Radius = 1 };

			Assert.That(SquareCalculator.GetSquare(circle), Is.EqualTo(Math.PI));
		}

		[Test]
		public void TestCircleSquare100Pi()
		{
			var circle = new Circle { Radius = 10 };

			Assert.That(SquareCalculator.GetSquare(circle), Is.EqualTo(100 * Math.PI));
		}
	}
}
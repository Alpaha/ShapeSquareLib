using ShapeSquareLib.Shapes.Interfaces;

namespace ShapeSquareLib
{
	public static class SquareCalculator
	{
		//Если бы пилил не либу, а АПИ, тут был бы конструктор с инжектированием, вместо дженерика
		public static double GetSquare<TShape>(TShape shape) where TShape : IShape => shape.GetSquare();
	}
}
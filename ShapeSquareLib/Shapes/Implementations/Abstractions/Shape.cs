using ShapeSquareLib.Shapes.Interfaces;

namespace ShapeSquareLib.Shapes.Implementations.Abstractions
{
    public abstract class Shape : IShape
    {
        protected string Name { get; set; }
        public abstract double GetSquare();
    }
}
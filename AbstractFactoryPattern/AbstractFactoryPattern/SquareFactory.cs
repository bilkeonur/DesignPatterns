using System;
namespace AbstractFactoryPattern
{
    public class SquareFactory: ShapeFactory
    {
        public SquareFactory()
        {
        }

        public IShape GetShape()
        {
            return new Square();
        }
    }
}


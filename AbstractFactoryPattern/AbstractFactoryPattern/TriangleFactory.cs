using System;
namespace AbstractFactoryPattern
{
    public class TriangleFactory: ShapeFactory
    {
        public TriangleFactory()
        {
        }

        public IShape GetShape()
        {
            return new Triangle();
        }
    }
}


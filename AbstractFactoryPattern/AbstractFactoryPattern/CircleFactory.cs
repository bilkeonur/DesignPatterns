using System;
namespace AbstractFactoryPattern
{
    public class CircleFactory: ShapeFactory
    {
        public CircleFactory()
        {
        }

        public IShape GetShape()
        {
            return new Circle();
        }
    }
}


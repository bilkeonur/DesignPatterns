using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape circle = shapeFactory.GetShape("circle");
            circle.Draw();

            IShape square = shapeFactory.GetShape("square");
            square.Draw();

            IShape triangle = shapeFactory.GetShape("triangle");
            triangle.Draw();
        }
    }
}


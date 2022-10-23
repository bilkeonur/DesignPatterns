using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleFactory circleFactory = new CircleFactory();
            IShape circle = circleFactory.GetShape();
            circle.Draw();

            SquareFactory squareFactory = new SquareFactory();
            IShape square = squareFactory.GetShape();
            square.Draw();

            TriangleFactory triangleFactory = new TriangleFactory();
            IShape triangle = triangleFactory.GetShape();
            triangle.Draw();
        }
    }
}


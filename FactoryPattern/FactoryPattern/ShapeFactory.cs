using System;
namespace FactoryPattern
{
    public class ShapeFactory
    {
        public ShapeFactory()
        {
        }

        public IShape GetShape(String shapeName)
        {
            if(shapeName == "circle")
            {
                return new Circle();
            }
            else if (shapeName == "triangle")
            {
                return new Triangle();
            }
            else if (shapeName == "square")
            {
                return new Square();
            }
            else
            {
                return null;
            }
        }
    }
}


using System;
namespace FactoryPattern
{
    public class Triangle: IShape
    {
        public Triangle()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Üçgen Çizildi");
        }
    }
}


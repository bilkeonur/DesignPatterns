using System;
namespace AbstractFactoryPattern
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


using System;
namespace FactoryPattern
{
    public class Square: IShape
    {
        public Square()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Kare Çizildi");
        }
    }
}


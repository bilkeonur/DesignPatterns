using System;
namespace AbstractFactoryPattern
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


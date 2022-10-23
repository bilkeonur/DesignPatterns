using System;
namespace AbstractFactoryPattern
{
    public class Circle: IShape
    {
        public Circle()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Çember Çizildi");
        }
    }
}


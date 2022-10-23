using System;
namespace FactoryPattern
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


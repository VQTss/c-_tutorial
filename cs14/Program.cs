using System;


/// Miêu tả tính trừu tượng
namespace cs14
{
    class Program
    {

        abstract class Shape
        {
            public abstract void Draw();
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle Draw");
            }
        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rect Draw");
            }
        }


        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();
        }
    }
}

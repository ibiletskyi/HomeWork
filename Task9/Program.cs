using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Figure[] { new Figure(1, 1), new Rectangle(2, 2), new Square(3, 3) };
            DrawAll(array);
        }

        static void DrawAll(params IDrawable[] array)
        {
            foreach (var item in array)
            {
                item.Draw();
            }
        }
    }
}

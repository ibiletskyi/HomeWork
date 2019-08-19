using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new IDrawable[] { new Figure(), new Rectangle(), new Square() };
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

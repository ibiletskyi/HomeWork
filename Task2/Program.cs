using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Task 2-----");
            Console.WriteLine("Enter rectangle coordinates");
            float x1, y1, x2, y2;

            do Console.Write("x1: ");
            while (!float.TryParse(Console.ReadLine(), out x1));
            do Console.Write("y1: ");
            while (!float.TryParse(Console.ReadLine(), out y1));
            do Console.Write("x2: ");
            while (!float.TryParse(Console.ReadLine(), out x2));
            do Console.Write("y2: ");
            while (!float.TryParse(Console.ReadLine(), out y2));

            var rectangle = new Rectangle(x1, y1, x2, y2);
            Console.WriteLine("----------Task 2 Results----------");
            Console.WriteLine("Square is {0}", rectangle.Square);
            Console.WriteLine("Perimeter is {0}", rectangle.Perimeter);
        }
    }
}

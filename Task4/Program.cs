using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Task 4 / Rectangle Part-----");
            Console.WriteLine("Enter rectangle coordinates");
            float x1, y1, x2, y2, radius;
            
            do Console.Write("x1: ");
            while (!float.TryParse(Console.ReadLine(), out x1));
            do Console.Write("y1: ");
            while (!float.TryParse(Console.ReadLine(), out y1));
            do Console.Write("x2: ");
            while (!float.TryParse(Console.ReadLine(), out x2));
            do Console.Write("y2: ");
            while (!float.TryParse(Console.ReadLine(), out y2));

            Console.WriteLine("----------Results Task 4 / Rectangle Part----------");
            Console.WriteLine("Square is {0}", Rectangle.Square(x1, y1, x2, y2));
            Console.WriteLine("Perimeter is {0}", Rectangle.Perimeter(x1, y1, x2, y2));


            Console.WriteLine("----------Task 4/ Circle Part-------");
            do Console.Write("Enter radius of Circle: ");
            while (!float.TryParse(Console.ReadLine(), out radius));

           
            Console.WriteLine("----------Results Task 4/ Circle Part----------");
            Console.WriteLine("Square of Circle is {0}", Circle.Square(radius));
            Console.WriteLine("Length of Circle is {0}", Circle.Length(radius));
        }
    }
}

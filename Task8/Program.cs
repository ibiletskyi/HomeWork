using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Task 8-(3)----");

            new Figure(12, 12).Draw();
            new Square(12, 12).Draw();
            new Rectangle(10, 5).Draw();
        }
    }
}

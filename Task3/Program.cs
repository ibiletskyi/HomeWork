using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Task 3----------");            
            float radius;
            do Console.Write("Enter radius of Circle: ");
            while(!float.TryParse(Console.ReadLine(),out radius));

            var circle = new Circle();
            Console.WriteLine("----------Task 3 Results----------");
            Console.WriteLine("Square of Circle is {0}", circle.Square(radius));
            Console.WriteLine("Length of Circle is {0}", circle.Length(radius));
        }
    }
}

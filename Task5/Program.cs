using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Task 5----------");
            Console.WriteLine("multiply/divide complex numbers ex. 7-4i (7,-4) and 3+2i (3,2)");

            Console.WriteLine("Enter real/imaginary parts of 1st number");
            float a1, a2, b1, b2;
            do Console.Write("real: ");
            while (!float.TryParse(Console.ReadLine(),out a1));
            do Console.Write("imaginary: ");
            while (!float.TryParse(Console.ReadLine(), out a2));

            Console.WriteLine("Enter real/imaginary parts of 2nd number");
            do Console.Write("real: ");
            while(!float.TryParse(Console.ReadLine(),out b1));
            do Console.Write("imaginary: ");
            while(!float.TryParse(Console.ReadLine(),out b2));

            var c1 = new ComplexNumber(a1, a2);
            var c2 = new ComplexNumber(b1, b2);

            var multiplication = c1 * c2;
            var division = c1 / c2;

            Console.WriteLine("----------Results-Task 5-----------");
            Console.WriteLine("Multiplication (1st*2nd) is {0}", multiplication);
            Console.WriteLine("Division (1st/2nd) is {0}", division);
        }
    }
}

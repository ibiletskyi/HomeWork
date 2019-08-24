using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Display task1-----");
            var part1 = new Task1();
            part1.Draw();
            Console.WriteLine("-----Display task2-----");
            var part2 = new Task2();
            part2.Draw();
            Console.WriteLine("-----Display task3-----");
            var part3 = new Task3();
            
            int pageNumber;
            bool isNumber;
            do
            {
                Console.Write("Enter page:");
                isNumber = int.TryParse(Console.ReadLine(), out pageNumber);                
                if (isNumber)
                    part3.DisplayPage(pageNumber);
            } while (isNumber);
        }
    }
}

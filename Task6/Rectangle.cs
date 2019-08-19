using System;

namespace Task6
{
    public class Rectangle : Figure
    {
        public override string Draw()
        {
            var name = "I'm the Rectangle";
            Console.WriteLine(name);
            return name;
        }
    }
}

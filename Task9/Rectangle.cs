using System;

namespace Task9
{
    public class Rectangle : IDrawable
    {       
        public string Draw()
        {
            var name = "I'm the Rectangle";
            Console.WriteLine(name);
            return name;
        }
    }
}

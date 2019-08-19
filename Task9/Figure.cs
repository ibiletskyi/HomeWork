using System;

namespace Task9
{
    public class Figure : IDrawable
    {       
        public string Draw()
        {
            var name = "I'm the Figure";
            Console.WriteLine(name);
            return name;
        }
    }
}

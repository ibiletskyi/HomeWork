using System;


namespace Task9
{
    public class Square : IDrawable
    {
        public string Draw()
        {
            var name = "I'm the Square";
            Console.WriteLine(name);
            return name;
        }
    }
}

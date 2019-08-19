using System;


namespace Task8
{
    public class Square : Figure
    {
        public Square(float x, float y) : base(x, y)
        {

        }

        public override string Draw()
        {
            var name = "I'm the Square";
            Console.WriteLine(name);
            return name;
        }
    }
}

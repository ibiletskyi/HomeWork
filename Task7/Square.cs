using System;


namespace Task7
{
    public class Square : Figure
    {
        public Square(float x, float y) : base(x, y)
        {

        }
        public override string Draw()
        {
            var name = this.GetType().Name;
            Console.WriteLine(name);
            return name;
        }
    }
}

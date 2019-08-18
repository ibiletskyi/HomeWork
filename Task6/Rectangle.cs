using System;

namespace Task6
{
    public class Rectangle : Figure
    {
        public override string Draw()
        {
            var name = this.GetType().Name;
            Console.WriteLine(name);
            return name;
        }
    }
}

using System;

namespace Task8
{
    public class Figure
    {
        readonly float x, y;
        public float X { get { return x; } }
        public float Y { get { return y; } }

        public Figure(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual string Draw()
        {
            var name = this.GetType().Name;
            Console.WriteLine(name);
            return name;
        }
    }
}

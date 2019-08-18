namespace Task7
{
    public abstract class Figure
    {
        readonly float x, y;
        public float X { get { return x; } }
        public float Y { get { return y; } }

        public Figure(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract string Draw();
    }
}

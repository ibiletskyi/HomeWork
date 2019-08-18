namespace Task2
{
    public class Rectangle
    {
        private readonly float x1;
        private readonly float y1;
        private readonly float x2;
        private readonly float y2;

        private readonly float width;
        private readonly float height;

        public float Square { get; private set; }

        public float Perimeter { get; private set; }

        public Rectangle(float x1, float y1, float x2, float y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;

            width = Abs(this.x1 - this.x2);
            height = Abs(this.y1 - this.y2);
            Square = width * height;
            Perimeter = 2 * width + 2 * height;
        }

        public static float Abs(float n)
        {
            n = (n < 0) ? -n : n;
            return n;
        }
    }
}

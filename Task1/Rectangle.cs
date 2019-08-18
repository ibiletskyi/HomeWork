namespace Task1
{
    public class Rectangle
    {
        private readonly float x1;
        private readonly float y1;
        private readonly float x2;
        private readonly float y2;
        
        public Rectangle(float x1, float y1, float x2, float y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public static float Abs(float n)
        {
            n = (n < 0) ? -n : n;
            return n;
        }

        public float Square()
        {
            var width = Abs(x1 - x2);
            var height = Abs(y1 - y2);
            return width * height;
        }
        public float Perimeter()
        {
            var width = Abs(x1 - x2);
            var height = Abs(y1 - y2);
            return 2 * width + 2 * height;
        }
    }
}

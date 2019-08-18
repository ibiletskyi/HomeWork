namespace Task4
{
    public static class Rectangle
    {
        public static float Abs(float n)
        {
            n = (n < 0) ? -n : n;
            return n;
        }

        public static float Square(float x1, float y1, float x2, float y2)
        {
            var width = Abs(x1 - x2);
            var height = Abs(y1 - y2);
            return width * height;
        }

        public static float Perimeter(float x1, float y1, float x2, float y2)
        {
            var width = Abs(x1 - x2);
            var height = Abs(y1 - y2);
            return 2 * width + 2 * height;
        }
    }
}

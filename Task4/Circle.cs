namespace Task4
{
    public static class Circle
    {
        const float Pi = 3.14f;
        public static float Square(float radius)
        {
            return Pi * radius * radius;
        }
        public static float Length(float radius)
        {
            return 2 * Pi * radius;
        }
    }
}

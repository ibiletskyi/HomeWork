using NUnit.Framework;
using Task4;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        public void AbsTest()
        {
            Assert.That(Rectangle.Abs(-1.2f), Is.EqualTo(1.2f));
            Assert.AreEqual(Rectangle.Abs(1.21f), 1.21f);
        }

        [Test]
        public void RectangleTest1()
        {           
            Assert.AreEqual(Rectangle.Perimeter(-2f, 1, 1, -2), 12);
            Assert.AreEqual(Rectangle.Square(-2f, 1, 1, -2), 9);
        }

        [Test]
        public void RectangleTest2()
        {
            Assert.AreEqual(Rectangle.Perimeter(0, 0, 0, 0), 0);
            Assert.AreEqual(Rectangle.Square(0, 0, 0, 0), 0);
        }

        public void RectangleTest3()
        {
            Assert.AreEqual(Rectangle.Perimeter(0, 0, 3, 12), 30);
            Assert.AreEqual(Rectangle.Square(0, 0, 3, 12), 36);
        }

        [Test]
        public void CircleTest()
        {
            Assert.AreEqual(Circle.Square(3f), 28.26f);
            Assert.AreEqual(Circle.Length(3f), 18.84f);
        }
    }
}
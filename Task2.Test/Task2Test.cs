using NUnit.Framework;
using Task2;

namespace Tests
{
    [TestFixture]
    public class Task2Test
    {
        [Test]
        public void AbsTest()
        {
            Assert.That(Rectangle.Abs(-1.2f), Is.EqualTo(1.2f));
            Assert.AreEqual(Rectangle.Abs(1.21f), 1.21f);
        }

        [Test]
        public void InstanceMethodTest1()
        {
            var rect = new Rectangle(-2f, 1, 1, -2);
            Assert.AreEqual(rect.Perimeter, 12);
            Assert.AreEqual(rect.Square, 9);
        }

        [Test]
        public void InstanceMethodTest2()
        {
            var rect = new Rectangle(0, 0, 0, 0);
            Assert.AreEqual(rect.Perimeter, 0);
            Assert.AreEqual(rect.Square, 0);
        }

        public void InstanceMethodTest3()
        {
            var rect = new Rectangle(0, 0, 3, 12);
            Assert.AreEqual(rect.Perimeter, 30);
            Assert.AreEqual(rect.Square, 36);
        }
    }
}
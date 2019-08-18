using NUnit.Framework;
using Task3;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var circle = new Circle();

            Assert.AreEqual(circle.Square(3f), 28.26f);
            Assert.AreEqual(circle.Length(3f), 18.84f);
        }
    }
}
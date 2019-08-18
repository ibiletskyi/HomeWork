using NUnit.Framework;
using Task7;

namespace Tests
{
    [TestFixture]
    public class Tests
    {       

        [Test]
        public void Test1()
        {
            Assert.AreEqual(new Rectangle(12,5).X , 12);
            Assert.AreEqual(new Rectangle(12, 5).Y, 5);
        }
    }
}
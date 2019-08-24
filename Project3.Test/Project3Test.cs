using NUnit.Framework;
using Project3;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        
        [Test]
        public void Task1CountOfPersonsTest()
        {
            Assert.AreEqual(new Task1().GetCountOfPersons(), 6);           
        }

        [Test]
        public void Task1PersonsHasAtleastThreePhonenumber()
        {
            Assert.AreEqual(new Task1().Persons.All(p=>p.PhoneNumbers.Count() >= 3), true);
        }

        [Test]
        public void Task2CountOfPersonsTest()
        {
            Assert.AreEqual(new Task2().GetCountOfPersons(), 8);
        }

        [Test]
        public void Task2PersonsHasAtleastThreePhonenumber()
        {
            Assert.AreEqual(new Task2().Persons.All(p => p.PhoneNumbers.Count() >= 3), true);
        }

        [Test]
        public void Task3RandomStringTest()
        {
            Assert.AreEqual(new Task3().RandomString(4,false).Length, 4);           
        }

        [Test]
        public void Task3ConditionStringTest()
        {
            var task3 = new Task3();
            bool hasLatterZ = false;
            foreach (var item in task3.StringItems)
            {
                hasLatterZ |= item.StartsWith("Z");
            }
            Assert.AreNotEqual(hasLatterZ, true);
        }

        [Test]
        public void Task3TestNumberOfPage()
        {
            var task3 = new Task3();
           
            Assert.That(task3.NumberOfPages > 0);
        }
    }
}
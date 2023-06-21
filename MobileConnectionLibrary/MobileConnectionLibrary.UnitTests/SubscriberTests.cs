using NUnit.Framework;

namespace MobileConnectionLibrary.UnitTests_
{
    [TestFixture]
    public class Tests
    {
        static Subscriber sub;

        [SetUp]
        public void Setup()
        {
            sub = new Subscriber("John", "Smith", 8119480348, 54542);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(sub.Name, Is.EqualTo("John"));
            Assert.That(sub.Surname, Is.EqualTo("Smith"));
            Assert.That(sub.PhoneNumber, Is.EqualTo(8119480348));
            Assert.That(sub.ContractNumber, Is.EqualTo(54542));
        }

        [Test]
        public void GetInfo_Subscriber_ValuesString()
        {
            string expectedInfo = "John Smith. ";
            expectedInfo += "Телефонный номер: 8119480348. ";
            expectedInfo += "Номер договора: 54542. ";
            Assert.That(sub.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}
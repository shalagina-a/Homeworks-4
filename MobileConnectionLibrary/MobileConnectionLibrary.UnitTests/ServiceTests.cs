using NUnit.Framework;

namespace MobileConnectionLibrary.UnitTests_
{
    [TestFixture]
    public class ServiceTests
    {
        Service call, text_message, internet;
        [SetUp]
        public void Setup()
        {
            call = new Call(10, 100);
            text_message = new TextMessage(5, 500);
            internet = new Internet(50, 100);
        }
        [Test]
        public void PaymentTest()
        {
            Assert.That(call.Payment, Is.EqualTo(1000));
            Assert.That(text_message.Payment, Is.EqualTo(2500));
            Assert.That(internet.Payment, Is.EqualTo(5000));
        }

        [Test]
        public void CallGetInfoTest()
        {
            var expected = "К оплате 1000";
            Assert.That(call.GetInfo(), Is.EqualTo(expected));
        }

        [Test]
        public void TextMessageGetInfoTest()
        {
            var expected = "К оплате 2500";
            Assert.That(text_message.GetInfo(), Is.EqualTo(expected));
        }

        [Test]
        public void InternetGetInfoTest()
        {
            var expected = "К оплате 5000";
            Assert.That(internet.GetInfo(), Is.EqualTo(expected));
        }
    }
}
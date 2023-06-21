using MobileConnection;
using NUnit.Framework;
using System.Reflection;

namespace MobileConnectionLibrary.UnitTests_
{
    [TestFixture]
    public class OperatorTests
    {
        Operator project;
        Subscriber[] subscribers;

        [SetUp]
        public void Setup()
        {
            var alexander = new Subscriber("Александр", "Богданов", 742701079, 6645);
            var mihail = new Subscriber("Михаил", "Некрасов", 744036776, 633);
            var alisa = new Subscriber("Алиса", "Князева", 789997127, 902);
            var jaroslav = new Subscriber("Ярослав", " Поляков", 792859559429, 6);
            var maria = new Subscriber("Мария", "Афанасьева", 792546915726, 5);

            subscribers = new Subscriber[] { alexander, mihail, alisa, jaroslav, maria };

            project = new Operator(OrganizationName.MTS, 172381247, subscribers);
        }
        [Test]
        public void ConstructorTest()
        {
            Assert.That(project.OrganizationName, Is.EqualTo(OrganizationName.MTS));
            Assert.That(project.OrganizationTaxIdentificationNumber, Is.EqualTo(172381247));

        }
        [Test]
        public void CountTest()
        {
            Assert.That(project.Count, Is.EqualTo(5));
        }
        [Test]
        public void IEnumerableTest()
        {
            var i = 0;
            foreach (var subscriber in project)
                Assert.That(subscriber, Is.SameAs(subscribers[i++]));
        }
    }

}
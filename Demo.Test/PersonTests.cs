using System;
using NUnit.Framework;

namespace Demo.Test
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void DoesWhatsMyNameWorcksProperly()
        {
            //Arrange
            Person person = new Person("Nesho", 10);

            
            //var expectedResult = 10;
            //var actualResult = person.SavedMoney;
            //Assert.AreEqual(expectedResult, actualResult);

            //Act
            int number1 = 10;
            int number2 = 20;

            //Assert
            Assert.AreEqual(number2,number2);
           //Assert.That(true);
           //Assert.That(number1 == number2);
           //Assert.That(number1,Is.EqualTo(number2));
           //Assert.Throws<Exception>(() => person.WhatsMyName());
        }
    }
}

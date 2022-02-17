using System;
using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyShoudLosesHealthIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(100,100);

        //Act
        dummy.TakeAttack(10);

        var expectedResult = 90;
        var actualResult = dummy.Health;

        //Asssert
        Assert.AreEqual(expectedResult,actualResult);
    }

    [Test]
    public void DeadDummyShoudThrowExceptionIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 100);
        //Act Assert
        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
    }
    [Test]
    public void DeadDummyShoudGiveExp()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 100);

        //Act - Assert
        var expectedResult = 100;
        var actualResult = dummy.GiveExperience();

        Assert.AreEqual(expectedResult, actualResult);
    }
}

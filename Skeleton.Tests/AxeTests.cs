using System;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    [Test]
    [TestCase(100,100,100,100,99)]
    public void WeaponShoudLosesDurabilityAfterAttack(int health,int exp,int atack,int durability,int expectedResult)
    {
        //Arrange
        Dummy dummy = new Dummy(health,exp);
        Axe axe = new Axe(atack,durability);
        //Act
        axe.Attack(dummy);
        //Assert
       
        var actualResult = axe.DurabilityPoints;
        Assert.AreEqual(expectedResult,actualResult);
    }
    [Test]
    public void attackShouldThrowInvalidOperationException()
    {
        //Arrange
        Dummy dummy = new Dummy(10, 10);
        Axe axe = new Axe(20, 0);
        //Act-Assert
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        //Assert


    }
}
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        //Arrange
        long number = 1;
        //Act

        //Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(number), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long primeNumber = 29; 

        // Act
        long largestPrimeFactor = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        // Assert
        Assert.AreEqual(primeNumber, largestPrimeFactor);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long largeNumber = 693; 

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(largeNumber);

        // Assert
        Assert.AreEqual(11, result);
    }
}

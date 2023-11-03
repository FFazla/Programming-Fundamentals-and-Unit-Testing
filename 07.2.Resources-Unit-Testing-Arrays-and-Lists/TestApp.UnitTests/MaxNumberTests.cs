using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        //Arrange
        List<int> oneElementList = new() { 42 };
        //Act
        int result = MaxNumber.FindMax(oneElementList);
        //Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> positiveList = new() { 42, 44, 1 , 47 };
        //Act
        int result = MaxNumber.FindMax(positiveList);
        //Assert
        Assert.That(result, Is.EqualTo(47));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> negativeList = new() { -42, -1, -100, -43 };
        //Act
        int result = MaxNumber.FindMax(negativeList);
        //Assert
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> mixList = new() { -42, 1, -100, 43 };
        //Act
        int result = MaxNumber.FindMax(mixList);
        //Assert
        Assert.That(result, Is.EqualTo(43));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        //Arrange
        List<int> duplicateList = new() { 42, 42, 1, 3 };
        //Act
        int result = MaxNumber.FindMax(duplicateList);
        //Assert
        Assert.That(result, Is.EqualTo(42));
    }
}

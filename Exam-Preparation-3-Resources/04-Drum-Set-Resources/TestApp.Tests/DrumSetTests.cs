using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        //Arrange
        decimal money = 100;
        List<int> initialQuality = new() { 2, 3 };
        List<string> commands = new() { "1", "1" };
        //Act & Assert
        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);

    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        // TODO: implement the test
        //Arrange
        decimal money = 100;
        List<int> initialQuality = new() { 2, 3 };
        List<string> commands = new() { "1", "string", "Hit it again, Gabsy!" };
        //Act & Assert
        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);

    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        //Arrange
        decimal money = 100;
        List<int> initialQuality = new() { 3, 4 };
        List<string> commands = new() { "1", "1", "Hit it again, Gabsy!" };
        string expcted = 
        //Act

        //Assert
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        // TODO: implement the test
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        // TODO: implement the test
    }
}

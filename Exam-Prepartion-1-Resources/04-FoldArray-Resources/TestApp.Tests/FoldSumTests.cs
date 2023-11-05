using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] { 1, 2, 3, 4}, "3 7")]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8}, "5 5 13 13")]
    [TestCase(new int[] { 3, 3, 3, 3}, "6 6")]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}, "9 9 9 9 25 25 25 25")]
    [TestCase(new int[] { -1, -1, -1, -1}, "-2 -2")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        // Act
        string result = FoldSum.FoldArray(arr);

        // Assert
        Assert.AreEqual(expected, result);
    }
}

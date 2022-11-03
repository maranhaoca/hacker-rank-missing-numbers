using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var arr = new List<int> { 7, 2, 5, 3, 5, 3 };
        var brr = new List<int> { 7, 2, 5, 4, 6, 3, 5, 3 };

        var expected = new List<int> { 4, 6 };
        var actual = Result.missingNumbers(arr, brr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var arr = new List<int> { 11, 4, 11, 7, 13, 4, 12, 11, 10, 14 };
        var brr = new List<int> { 11, 4, 11, 7, 3, 7, 10, 13, 4, 8, 12, 11, 10, 14, 12 };

        var expected = new List<int> { 3, 7, 8, 10, 12 };
        var actual = Result.missingNumbers(arr, brr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var arr = new List<int> { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
        var brr = new List<int> { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };

        var expected = new List<int> { 204, 205, 206 };
        var actual = Result.missingNumbers(arr, brr);

        Assert.Equal(expected, actual);
    }
}
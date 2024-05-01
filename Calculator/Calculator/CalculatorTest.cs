using Domain;
using FluentAssertions;

namespace CalculatorTester;

public class CalculatorTest
{
    //[Fact]
    //public void SumOf2And2Is4() // Test code
    //{
    //    Calculator cal = new();
    //    var result = cal.Sum(2, 2);

    //    // 1. manually use check condition
    //    //if (result != 4)
    //    //    throw new Exception($"The Sum(2,2) is epexted to equal to 4, but the result is {result}.");

    //    // 2. Use nuget package
    //    result.Should().Be(4); // install nuget package: fient assertion package.
    //}

    // 3. completely simplify the test code with the help with nuget package
    [Fact]
    public void SumOf2And2Is4() => new Calculator()
        .Sum(2,2)
        .Should().Be(4);
}


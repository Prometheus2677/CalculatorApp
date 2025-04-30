using CalculatorApp;

using Xunit;

namespace CalculatorApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        Assert.Equal(5, _calc.Add(2, 3));
    }

    [Fact]
    public void Subtract_ReturnsCorrectResult()
    {
        Assert.Equal(1, _calc.Subtract(4, 3));
    }

    [Fact]
    public void Multiply_ReturnsCorrectResult()
    {
        Assert.Equal(12, _calc.Multiply(3, 4));
    }

    [Fact]
    public void Divide_ReturnsCorrectResult()
    {
        Assert.Equal(2, _calc.Divide(6, 3));
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(5, 0));
    }
}

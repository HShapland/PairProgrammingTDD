namespace PairProgrammingTDD.Tests;

public class Tests
{
    // OBJECTIVE - Resturn the sum of even numbers in a fibanacci sequence (starting with 1 and 2)
    [Ignore("")]
    [TestCase(1)]
    public void FibonacciProblem_WhenGivenInput1_Returns1(int input)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(1));
    }

    [Ignore("")]
    [TestCase(2, 2)]
    [TestCase(3, 3)]
    public void FibonacciProblem_WhenGivenInputNumber_ReturnsSameNumber(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }

    [Ignore("")]
    [TestCase(4, 5)]
    public void FibonacciProblem_WhenGivenInput4_Returns5(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }

    [Ignore("")]
    [TestCase(5, 8)]
    public void FibonacciProblem_WhenGivenInput5_Returns8(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }

    [Ignore("")]
    [TestCase(6, 13)]
    public void FibonacciProblem_WhenGivenInput6_Returns13(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }

    [TestCase(2, 3)]
    [TestCase(3, 6)]
    [TestCase(4, 11)]
    public void FibonacciProblem_WhenGivenInput_ReturnsSumOfNumbersInFibonacciSequence(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }
}
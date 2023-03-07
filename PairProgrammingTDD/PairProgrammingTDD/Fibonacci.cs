namespace PairProgrammingTDD;

public class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }

    /* Step 1
    public static int FibonacciSequence(int input)
    {
        return 1;
    }
    */

    /* Step 2
    public static int FibonacciSequence(int input)
    {
        return input;
    }
    */

    public static int FibonacciProblem(int input)
    {
        int firstValue = 1;
        int secondValue = 2;
        int current = firstValue + secondValue;

        if (input == 1) return firstValue;
        if (input == 2) return secondValue;

        for (int i = 3; i < input; i++)
        {
            firstValue = secondValue;
            secondValue = current;
            current = firstValue + secondValue;
        }

        return current;
    }
}
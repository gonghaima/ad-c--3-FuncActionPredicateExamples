namespace FuncActionPredicateExamples;

class Program
{
    static void Main(string[] args)
    {
        MathClass mathClass = new MathClass();

        Func<int, int, int> calc = mathClass.Sum;

        int result = calc(1,2);
        Console.WriteLine($"Result: {result}");
    }
}

public class MathClass
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}


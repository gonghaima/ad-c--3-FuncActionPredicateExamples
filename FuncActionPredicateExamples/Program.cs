namespace FuncActionPredicateExamples;

class Program
{
    static void Main(string[] args)
    {
        MathClass mathClass = new MathClass();

        //Func<int, int, int> calc = mathClass.Sum;
        //Func<int, int, int> calc = delegate (int a, int b) { return a + b; };
        Func<int, int, int> calc = (a, b) => a + b;

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


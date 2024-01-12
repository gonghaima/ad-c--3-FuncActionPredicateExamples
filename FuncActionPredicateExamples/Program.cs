namespace FuncActionPredicateExamples;

class Program
{
    delegate TResult Func2<out TResult>();
    delegate TResult Func2<in T1, out TResult>(T1 arg);
    delegate TResult Func2<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
    delegate TResult Func2<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);

    static void Main(string[] args)
    {
        // MathClass mathClass = new MathClass();

        float d = 2.3f, e = 4.56f;
        int f = 5;
        Func<float, float, int, float> calc2 = (arg1, arg2, arg3) => (arg1 + arg2) * arg3;

        float result2 = calc2(d,e,f);
        Console.WriteLine($"Result: {result2}");

        //Func<int, int, int> calc = mathClass.Sum;
        //Func<int, int, int> calc = delegate (int a, int b) { return a + b; };
        //Func<int, int, int> calc = (a, b) => a + b;
        // Func2<int, int, int> calc = (a, b) => a + b;


        //int result = calc(1,2);
        //Console.WriteLine($"Result: {result}");
    }
}

public class MathClass
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}


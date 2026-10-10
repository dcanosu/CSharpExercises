namespace CSharpExercises;

public class FactorialFinder : IExercise
{
    private readonly int _number;

    public FactorialFinder(int number)
    {
        _number = number;
    }
    public void Execute()
    {
        int n = _number;
        if (n >= 0)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Result: {factorial}");
        }
    }
}
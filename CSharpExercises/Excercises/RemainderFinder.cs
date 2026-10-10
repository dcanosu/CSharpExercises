namespace CSharpExercises;

public class RemainderFinder : IExercise
{
    private readonly int _num1;
    private readonly int _num2;

    public RemainderFinder(int num1, int num2)
    {
        _num1 = num1;
        _num2 = num2;
    }
    public void Execute()
    {
        if (_num2 != 0)
        {
            int remainder = _num1 % _num2;
            Console.WriteLine($"Result: {remainder}");
        }
        else
        {
            Console.WriteLine("Result: Division by zero is not allowed.");
        }
    }
}

namespace CSharpExercises;

public class DoubleOrTriple : IExercise
{
    private readonly double _num1;
    private readonly double _num2;

    public DoubleOrTriple(double num1, double num2)
    {
        _num1 = num1;
        _num2 = num2;
    }
    public void Execute()
    {
        if (_num1 >= _num2)
        {
            Console.WriteLine($"Result: {_num1 * 2}");
        }
        else
        {
            Console.WriteLine($"Result: {_num2 * 3}");
        }
    }
}
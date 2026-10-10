namespace CSharpExercises;

public class PositivePower : IExercise
{
    private readonly double _number;

    public PositivePower(double number)
    {
        _number = number;
    }
    public void Execute()
    {
        if (_number > 0)
        {
            Console.WriteLine($"Result: {_number * _number}");
        }
        else if (_number < 0)
        {
            Console.WriteLine("Result: Negative number.");
        }
        else
        {
            Console.WriteLine("Result: 0");
        }
    }
}
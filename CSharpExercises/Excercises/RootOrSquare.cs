namespace CSharpExercises;

public class RootOrSquare : IExercise
{
    private readonly double _number;

    public RootOrSquare(double number)
    {
        _number = number;
    }
    public void Execute()
    {
        if (_number > 0)
        {
            Console.WriteLine($"Result: {Math.Sqrt(_number)}");
        }
        else if (_number < 0)
        {
            Console.WriteLine($"Result: {_number * _number}");
        }
        else
        {
            Console.WriteLine("Result: 0");
        }
    }
}

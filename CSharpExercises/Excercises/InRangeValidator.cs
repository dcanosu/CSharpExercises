namespace CSharpExercises;

public class InRangeValidator : IExercise
{
    private readonly int _number;

    public InRangeValidator(int number)
    {
        _number = number;
    }
    public void Execute()
    {
        if (_number >= 10 && _number <= 20)
        {
            Console.WriteLine("Result: In the range.");
        }
        else
        {
            Console.WriteLine("Result: Out of the range.");
        }
    }
}

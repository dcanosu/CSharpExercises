namespace CSharpExercises;

public class AverageOfFour : IExercise
{
    private readonly double _num1;
    private readonly double _num2;
    private readonly double _num3;
    private readonly double _num4;

    public AverageOfFour(double num1, double num2, double num3, double num4)
    {
        _num1 = num1;
        _num2 = num2;
        _num3 = num3;
        _num4 = num4;
    }

    public void Execute()
    {
        double sum = 0;
        sum += _num1;
        sum += _num2;
        sum += _num3;
        sum += _num4;
        Console.WriteLine($"Result: {sum / 4.0}");
    }
}

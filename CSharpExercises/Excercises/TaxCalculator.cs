namespace CSharpExercises;

public class TaxCalculator : IExercise
{
    private readonly double _salary;

    public TaxCalculator(double salary)
    {
        _salary = salary;
    }
    public void Execute()
    {
        if (_salary > 12000)
        {
            double tax = (_salary - 12000) * 0.15;
            Console.WriteLine($"Result: {tax}");
        }
        else
        {
            Console.WriteLine("Result: No tax to pay.");
        }
    }
}


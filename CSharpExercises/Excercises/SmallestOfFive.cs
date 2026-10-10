namespace CSharpExercises;

public class SmallestOfFive : IExercise
{
    private readonly int[] _numbers;

    public SmallestOfFive(int[] numbers)
    {
        _numbers = numbers;
    }
    public void Execute()
    {
        int smallest = int.MaxValue;
        
        foreach (int number in _numbers)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"Result: {smallest}");
    }
}

namespace CSharpExercises;

public class MidweekDay : IExercise
{
    private readonly int _day;

    public MidweekDay(int day)
    {
        _day = day;
    }
    public void Execute()
    {
        if (_day >= 1 && _day <= 5)
        {
            string result = _day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                _ => "Number out of the working range."
            };
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Result: Number out of the working range.");
        }
    }
}

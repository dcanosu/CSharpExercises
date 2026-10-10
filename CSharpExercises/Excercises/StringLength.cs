namespace CSharpExercises;

public class StringLength : IExercise
{
    private readonly string _word;

    public StringLength(string word)
    {
        _word = word;
    }
    public void Execute()
    {
        Console.WriteLine($"Result: {_word.Length}");
    }
}

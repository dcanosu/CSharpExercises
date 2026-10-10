namespace CSharpExercises;

public class VowelCounter : IExercise
{
    private readonly string _word;

    public VowelCounter(string word)
    {
        _word = word;
    }
    public void Execute()
    {
        string word = _word;
        int count = 0;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        foreach (char c in word)
        {
            if (Array.Exists(vowels, v => v == c))
            {
                count++;
            }
        }
        Console.WriteLine($"Result: {count}");
    }
}

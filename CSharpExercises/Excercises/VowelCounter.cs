namespace CSharpExercises;

public class VowelCounter : IExcersice
{
    public void Excecute()
    {
        Console.Write("Pide una palabra al usuario: ");
        string word = (Console.ReadLine() ?? "").ToLower();
        int count = 0;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        foreach (char c in word)
        {
            if (Array.Exists(vowels, v => v == c))
            {
                count++;
            }
        }
        Console.WriteLine($"Resultado: {count}");
    }
}

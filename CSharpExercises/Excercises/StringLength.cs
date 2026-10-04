namespace CSharpExercises;

public class StringLength : IExcersice
{
    public void Excecute()
    {
        Console.Write("Pide una palabra al usuario: ");
        string word = Console.ReadLine() ?? "";
        Console.WriteLine($"Resultado: {word.Length}");
    }
}

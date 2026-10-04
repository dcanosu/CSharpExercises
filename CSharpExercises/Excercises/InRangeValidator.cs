namespace CSharpExercises;

public class InRangeValidator : IExcersice
{
    public void Excecute()
    {
        Console.Write("Pide un número al usuario: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            if (num >= 10 && num <= 20)
            {
                Console.WriteLine("Resultado: Está en el rango.");
            }
            else
            {
                Console.WriteLine("Resultado: Fuera del rango.");
            }
        }
    }
}
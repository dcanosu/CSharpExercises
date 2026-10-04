namespace CSharpExercises;

public class Exercises
{
    public static void Main(string[] args)
    {
        PositiveSquare();
    }

    // 1. Positive Power
    public static void PositiveSquare()
    {
        Console.Write("Ingrese un número positivo: ");
        if (double.TryParse(Console.ReadLine(), out double num))
        {
            if (num > 0)
            {
                Console.WriteLine($"Resultado: {num * num}");
            }
            else if (num < 0)
            {
                Console.WriteLine("Resultado: Número negativo.");
            }
            else
            {
                Console.WriteLine("Resultado: 0");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
    }
}

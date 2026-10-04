namespace CSharpExercises;

public class PositivePower : IExcersice
{
    public void Excecute()
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
    }
}
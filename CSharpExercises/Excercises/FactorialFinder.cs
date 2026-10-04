namespace CSharpExercises;

public class FactorialFinder : IExcersice
{
    public void Excecute()
    {
        Console.Write("Pide un número al usuario: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Resultado: {factorial}");
        }
        else
        {
            Console.WriteLine("Por favor ingrese un entero no negativo.");
        }
    }
}
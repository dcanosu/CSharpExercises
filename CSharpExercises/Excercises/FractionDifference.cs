namespace CSharpExercises;

public class FractionDifference : IExcersice
{
    public void Excecute()
    {
        Console.WriteLine("Fracción 1:");
        Console.Write("Numerador: ");
        int.TryParse(Console.ReadLine(), out int num1);
        Console.Write("Denominador: ");
        int.TryParse(Console.ReadLine(), out int den1);

        Console.WriteLine("Fracción 2:");
        Console.Write("Numerador: ");
        int.TryParse(Console.ReadLine(), out int num2);
        Console.Write("Denominador: ");
        int.TryParse(Console.ReadLine(), out int den2);

        if (den1 != 0 && den2 != 0)
        {
            double f1 = (double)num1 / den1;
            double f2 = (double)num2 / den2;
            double diff = Math.Abs(f1 - f2);

            Console.WriteLine($"Resultado {diff:F4}");
        }
    }
}

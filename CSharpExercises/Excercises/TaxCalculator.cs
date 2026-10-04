namespace CSharpExercises;

public class TaxCalculator : IExcersice
{
    public void Excecute()
    {
        Console.Write("Ingrese su salario anual: ");
        if (double.TryParse(Console.ReadLine(), out double salary))
        {
            if (salary > 12000)
            {
                double tax = (salary - 12000) * 0.15;
                Console.WriteLine($"Resultado: {tax}");
            }
            else
            {
                Console.WriteLine("Resultado: No debe impuestos.");
            }
        }
    }
}

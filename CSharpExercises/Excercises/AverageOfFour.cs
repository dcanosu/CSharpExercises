namespace CSharpExercises;

public class AverageOfFour : IExcersice
{
    public void Excecute()
    {
        Console.WriteLine("Ingrese cuatro números:");
        double sum = 0;
        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Número {i}: ");
            double.TryParse(Console.ReadLine(), out double val);
            sum += val;
        }
        Console.WriteLine($"Resultado: {sum / 4.0}");
    }
}

namespace CSharpExercises;

public class SmallestOfFive : IExcersice
{
    public void Excecute()
    {
        Console.WriteLine("Ingrese cinco números:");
        double smallest = double.MaxValue;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Número {i}: ");
            double.TryParse(Console.ReadLine(), out double val);
            if (val < smallest)
            {
                smallest = val;
            }
        }
        Console.WriteLine($"Resultado: {smallest}");
    }
}

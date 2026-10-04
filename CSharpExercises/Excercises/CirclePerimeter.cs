namespace CSharpExercises;

public class CirclePerimeter : IExcersice
{
    public void Excecute()
    {
        Console.Write("Ingresa el radio del círculo: ");
        if (double.TryParse(Console.ReadLine(), out double radio))
        {
            double perimeter = 2 * Math.PI * radio;
            Console.WriteLine($"Resultado: {perimeter:F2}");
        }
    }
}

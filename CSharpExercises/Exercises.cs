namespace CSharpExercises;

public class Exercises
{
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

    // 2. Double or Triple
    public static void DoubleOrTriple()
    {
        Console.Write("Ingrese el primer número: ");
        double.TryParse(Console.ReadLine(), out double num1);
        Console.Write("Ingrese el segundo número: ");
        double.TryParse(Console.ReadLine(), out double num2);

        if (num1 >= num2)
        {
            Console.WriteLine($"Resultado: {num1 * 2}");
        }
        else
        {
            Console.WriteLine($"Resultado: {num2 * 3}");
        }
    }

    // 3. Root or Square
    public static void RootOrSquare()
    {
        Console.Write("Ingrese un número: ");
        if (double.TryParse(Console.ReadLine(), out double num))
        {
            if (num > 0)
            {
                Console.WriteLine($"Resultado: {Math.Sqrt(num)}");
            }
            else if (num < 0)
            {
                Console.WriteLine($"Resultado: {num * num}");
            }
            else
            {
                Console.WriteLine("Resultado: 0");
            }
        }
    }

    // 4. Circle Perimeter
    public static void CirclePerimeter()
    {
        Console.Write("Ingresa el radio del círculo: ");
        if (double.TryParse(Console.ReadLine(), out double radio))
        {
            double perimeter = 2 * Math.PI * radio;
            Console.WriteLine($"Resultado: {perimeter:F2}");
        }
    }
}
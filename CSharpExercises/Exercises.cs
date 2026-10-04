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

    // 5. Midweek Day
    public static void MidweekDay()
    {
        Console.Write("Ingrese un número entre 1 y 7: ");
        if (int.TryParse(Console.ReadLine(), out int day))
        {
            string result = day switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                _ => "Número fuera del rango laboral."
            };
            Console.WriteLine($"Resultado: {result}");
        }
    }

    // 6. Tax Calculator
    public static void TaxCalculator()
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
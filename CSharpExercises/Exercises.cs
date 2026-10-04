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

    // 7. Remainder Finder
    public static void RemainderFinder()
    {
        Console.Write("Ingrese el primer número: ");
        int.TryParse(Console.ReadLine(), out int n1);
        Console.Write("Ingrese el segundo número: ");
        int.TryParse(Console.ReadLine(), out int n2);

        if (n2 != 0)
        {
            int remainder = n1 % n2;
            Console.WriteLine($"Resultado: {remainder}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre cero.");
        }
    }

    // 8. Sum of Evens
    public static void SumOfEvens()
    {
        int sum = 0;
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine($"Resultado: {sum}");
    }

    // 9. Fraction Difference
    public static void FractionDifference()
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
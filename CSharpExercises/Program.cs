namespace CSharpExercises;

public class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("=== MAIN MENU ===\n");
            Console.WriteLine("1. Positive Power");
            Console.WriteLine("2. Double or Triple");
            Console.WriteLine("3. Root or Square");
            Console.WriteLine("4. Circle Perimeter");
            Console.WriteLine("5. Midweek Day");
            Console.WriteLine("6. Tax Calculator");
            Console.WriteLine("7. Remainder Finder");
            Console.WriteLine("8. Sum of Evens");
            Console.WriteLine("9. Fraction Difference");
            Console.WriteLine("10. String Length");
            Console.WriteLine("11. Average of Four");
            Console.WriteLine("12. Smallest of Five");
            Console.WriteLine("13. Vowel Counter");
            Console.WriteLine("14. Factorial Finder");
            Console.WriteLine("15. InRange Validator");
            Console.WriteLine("0. Exit");
            Console.Write("\nChoice an option (1-15): ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("\n--- RUNNING EXERCISE {0} ---", option);

                IExcersice? exercise = option switch
                {
                    1 => new PositivePower(),
                    2 => new DoubleOrTriple(),
                    3 => new RootOrSquare(),
                    4 => new CirclePerimeter(),
                    5 => new MidweekDay(),
                    6 => new TaxCalculator(),
                    7 => new RemainderFinder(),
                    8 => new SumOfEvens(),
                    9 => new FractionDifference(),
                    10 => new StringLength(),
                    11 => new AverageOfFour(),
                    12 => new SmallestOfFive(),
                    13 => new VowelCounter(),
                    14 => new FactorialFinder(),
                    15 => new InRangeValidator(),
                    _ => null
                };

                if (exercise != null)
                {
                    exercise.Excecute();
                }
                else if (option != 0)
                {
                    Console.WriteLine("Invalid option.");
                }
                if (option != 0)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        } while (option != 0);
    }
}


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
                IExercise? exercise = null;

                switch (option)
                {
                    case 1:
                        {
                            double num = ReadValidDouble("Enter a positive number: ");
                            exercise = new PositivePower(num);
                            break;
                        }
                    case 2:
                        {
                            double num1 = ReadValidDouble("Enter the first number: ");
                            double num2 = ReadValidDouble("Enter the second number: ");
                            exercise = new DoubleOrTriple(num1, num2);
                            break;
                        }
                    case 3:
                        {
                            double num = ReadValidDouble("Enter a number: ");
                            exercise = new RootOrSquare(num);
                            break;
                        }
                    case 4:
                        {
                            double radius = ReadValidDoubleAndPositive("Enter the radius of the circle: ");
                            exercise = new CirclePerimeter(radius);
                            break;
                        }
                    case 5:
                        {
                            int day = ReadValidIntAndPositive("Enter a day of the week (1-7): ");
                            exercise = new MidweekDay(day);
                            break;
                        }
                    case 6:
                        {
                            double salary = ReadValidDoubleAndPositive("Enter your annual salary: ");
                            exercise = new TaxCalculator(salary);
                            break;
                        }
                    case 7:
                        {
                            int num1 = ReadValidInt("Enter the first number: ");
                            int num2 = ReadValidInt("Enter the second number: ");
                            while (num2 == 0)
                            {
                                Console.WriteLine("The second number cannot be zero. Please enter a valid number.");
                                num2 = ReadValidInt("Enter the second number: ");
                            }
                            exercise = new RemainderFinder(num1, num2);
                            break;
                        }
                    case 8:
                        {
                            exercise = new SumOfEvens();
                            break;
                        }
                    case 9:
                        {
                            int num1 = ReadValidInt("Enter the first number: ");
                            int den1 = ReadValidInt("Enter the first denominator: ");
                            int num2 = ReadValidInt("Enter the second number: ");
                            int den2 = ReadValidInt("Enter the second denominator: ");
                            exercise = new FractionDifference(num1, den1, num2, den2);
                            break;
                        }
                    case 10:
                        {
                            string word = ReadValidString("Enter a word: ");
                            exercise = new StringLength(word);
                            break;
                        }
                    case 11:
                        {
                            int num1 = ReadValidInt("Enter the first number: ");
                            int num2 = ReadValidInt("Enter the second number: ");
                            int num3 = ReadValidInt("Enter the third number: ");
                            int num4 = ReadValidInt("Enter the fourth number: ");
                            exercise = new AverageOfFour(num1, num2, num3, num4);
                            break;
                        }
                    case 12:
                        {
                            int[] numbers = new int[5];
                            for (int i = 0; i < 5; i++)
                            {
                                numbers[i] = ReadValidInt($"Enter the {i + 1} number: ");
                            }
                            exercise = new SmallestOfFive(numbers);
                            break;
                        }
                    case 13:
                        {
                            string word = ReadValidString("Enter a word: ");
                            exercise = new VowelCounter(word);
                            break;
                        }
                    case 14:
                        {
                            int num = ReadValidIntAndPositive("Enter a number: ");
                            exercise = new FactorialFinder(num);
                            break;
                        }
                    case 15:
                        {
                            int num = ReadValidIntAndPositive("Enter a number: ");
                            exercise = new InRangeValidator(num);
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Exiting the program...");
                            break;
                        }
                }

                if (exercise != null)
                {
                    Console.WriteLine("\n--- RUNNING EXERCISE {0} ---", option);
                    exercise.Execute();
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

    private static double ReadValidDoubleAndPositive(string v)
    {
        double value;
        Console.Write(v);
        while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
            Console.Write(v);
        }
        return value;
    }

    private static int ReadValidIntAndPositive(string v)
    {
        int value;
        Console.Write(v);
        while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            Console.Write(v);
        }
        return value;
    }

    private static string ReadValidString(string message)
    {
        string? input;
        bool isValid = false;

        do
        {
            Console.Write(message);
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty. Please enter a valid string.");
            }
            else if (double.TryParse(input, out _))
            {
                Console.WriteLine("Input cannot be a number. Please enter a valid string.");
            }
            else
            {
                isValid = true;
            }
        } while (!isValid);
        return input!;
    }

    private static int ReadValidInt(string message)
    {
        int value;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write(message);
        }
        return value;
    }

    private static double ReadValidDouble(string message)
    {
        double value;
        Console.Write(message);
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write(message);
        }
        return value;
    }
}

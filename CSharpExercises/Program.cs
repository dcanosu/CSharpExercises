namespace CSharpExercises;

public class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("=== MAIN MENU ===");
            Console.WriteLine("1. Positive Power");
            Console.WriteLine("2. Double or Triple");
            Console.WriteLine("3. Root or Square");
            Console.WriteLine("4. Circle Perimeter");
            Console.WriteLine("5. Midweek Day");
            Console.WriteLine("0. Exit");
            Console.Write("\nChoice an option (1-5): ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                if (option < 0 || option > 5)
                {
                    Console.WriteLine("Invalid option. Please select a number between 0 and 4.");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine("\n--- RUNNING EXERCISE {0} ---", option);
                switch (option)
                {
                    case 1: Exercises.PositiveSquare(); break;
                    case 2: Exercises.DoubleOrTriple(); break;
                    case 3: Exercises.RootOrSquare(); break;
                    case 4: Exercises.CirclePerimeter(); break;
                    case 5: Exercises.MidweekDay(); break;
                    case 0: Console.WriteLine("Exiting the program..."); break;
                    default: Console.WriteLine("Invalid option."); break;
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

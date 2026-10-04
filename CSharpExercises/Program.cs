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
            Console.WriteLine("0. Exit");
            Console.Write("\nChoice an option (1-15): ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("\n--- RUNNING EXERCISE {0} ---", option);

                IExcersice? exercise = option switch
                {
                    1 => new PositivePower(),
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

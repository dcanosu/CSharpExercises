namespace CSharpExercises;

public class RemainderFinder : IExcersice
{
    public void Excecute()
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
}

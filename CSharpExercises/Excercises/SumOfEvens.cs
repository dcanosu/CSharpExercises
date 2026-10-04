namespace CSharpExercises;

public class SumOfEvens : IExcersice
{
    public void Excecute()
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
}

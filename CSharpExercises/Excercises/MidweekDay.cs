namespace CSharpExercises;

public class MidweekDay : IExcersice
{
    public void Excecute()
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
}

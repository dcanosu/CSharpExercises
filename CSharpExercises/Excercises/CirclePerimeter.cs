namespace CSharpExercises;

public class CirclePerimeter : IExercise
{
    private readonly double _radius;

    public CirclePerimeter(double radius)
    {
        _radius = radius;
    }
    public void Execute()
    {
        if (_radius > 0)
        {
            double perimeter = 2 * Math.PI * _radius;
            Console.WriteLine($"Result: {perimeter:F2}");
        }
    }
}

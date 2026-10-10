namespace CSharpExercises;

public class FractionDifference : IExercise
{
    private readonly int _num1;
    private readonly int _den1;
    private readonly int _num2;
    private readonly int _den2;

    public FractionDifference(int num1, int den1, int num2, int den2)
    {
        _num1 = num1;
        _den1 = den1;
        _num2 = num2;
        _den2 = den2;
    }
    public void Execute()
    {
        double commonDenominator = (double)_den1 * _den2;
        double numerator1 = (double)_num1 * _den2;
        double numerator2 = (double)_num2 * _den1;
        double resultingNumerator = numerator1 - numerator2;

        if (resultingNumerator == 0)
        {
            Console.WriteLine("Result: 0");
            return;
        }

        double absNumerator = Math.Abs(resultingNumerator);
        double absDenominator = Math.Abs(commonDenominator);

        double gcd = GreatestCommonDivisor(absNumerator, absDenominator);

        double simplifiedNumerator = resultingNumerator / gcd;
        double simplifiedDenominator = commonDenominator / gcd;

        if (simplifiedDenominator == 1)
        {
            double finalSign = resultingNumerator < 0 ? -1 : 1;
            Console.WriteLine($"Result: {finalSign * Math.Abs(simplifiedNumerator)}");
        }
        else
        {
            string signPrefix = resultingNumerator < 0 ? "-" : "";
            Console.WriteLine($"Result: {signPrefix}{Math.Abs(simplifiedNumerator)}/{Math.Abs(simplifiedDenominator)}");
        }
    }

    private static double GreatestCommonDivisor(double a, double b)
    {
        while (b != 0)
        {
            double temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
namespace Amo1;

public static class Functions
{
    public static Function Func16 = new Function
    {
        F = x =>
        {
            double xIn3 = Math.Pow(x, 3);
            return Math.Pow(Math.Cos(x), 3) + xIn3 * Math.Pow(Math.Log2(Math.Sinh(x) + Math.Cosh(x)), 3) - xIn3 - 5;
        },
        Derivative = x =>
        {
            double xIn2 = x * x;
            double xIn3 = xIn2 * x;
            double cos = Math.Cos(x);
            double log = Math.Log2(Math.Sinh(x) + Math.Cosh(x));
            double ln2 = Math.Log(2);
            return 3 * xIn3 * log * log / ln2 +
                   3 * xIn2 * (log * log * log - 1) -
                   3 * cos * cos * Math.Sin(x);
        },
        SecondDerivative = x =>
        {
            double xIn2 = x * x;
            double xIn3 = xIn2 * x;
            double cos = Math.Cos(x);
            double sin = Math.Sin(x);
            double log = Math.Log2(Math.Sinh(x) + Math.Cosh(x));
            double logIn2 = log * log;
            double logIn3 = logIn2 * log;
            double ln2 = Math.Log(2);
            return 18 * xIn2 * log * log / ln2 +
                   6 * xIn3 * log / ln2 +
                   6 * x * (logIn3 - 1) +
                   3 * cos * cos * cos -
                   6 * cos * sin * sin;
        }
    };

    public static Function Func24 = new Function
    {
        F = x =>
        {
            double cosX = Math.Cos(x);
            return x * x * x - cosX * cosX - 5 * x - 3;
        },
        Derivative = x => 3 * x * x + 2 * Math.Cos(x) * Math.Sin(x) - 5,
        SecondDerivative = x => 6 * x + 2 * Math.Cos(2 * x)
    };
}
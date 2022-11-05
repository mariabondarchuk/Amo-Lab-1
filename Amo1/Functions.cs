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
			double xIn3 = Math.Pow(x, 3);
			double insideLog = Math.Sinh(x) + Math.Cosh(x);
			double log = Math.Log2(insideLog);
			return 3 * Math.Pow(Math.Cos(x), 2) * (-Math.Cos(x)) +
			       xIn3 * 3 * Math.Pow(log, 2) * 1 / (insideLog * Math.Log(2)) * insideLog +
			       3 * x * x + Math.Pow(log, 3)
			       - 3 * x * x;
		},
		SecondDerivative = x =>
		{
			double xIn3 = Math.Pow(x, 3);
			double insideLog = Math.Sinh(x) + Math.Cosh(x);
			double log = Math.Log2(insideLog);
			return 3 * Math.Pow(Math.Cos(x), 2) * (-Math.Cos(x)) +
			       xIn3 * 3 * Math.Pow(log, 2) * 1 / (insideLog * Math.Log(2)) * insideLog +
			       3 * x * x + Math.Pow(log, 3)
			       - 3 * x * x;
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
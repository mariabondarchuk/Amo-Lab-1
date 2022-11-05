namespace Amo1;

public class SecantAlgorithm : IAlgorithm
{
	public int MaxIterationsCount { get; } = 100_000;

	public double Run(double a, double b, double eps, Function f)
	{
		bool validation = EnsureCanUseSecantMethod(a, b, eps, f);
		if (validation == false)
		{
			Console.WriteLine("Secant method cannot be used as second derivative changes sign on [a, b]. Choose smaller [a, b]");
			return double.NaN;
		}

		double m1 = f.GetDerivativeMin(a, b, eps);
		Console.WriteLine($"m1 = {m1}");

		var iteration = 0;
		double x = DivideSegment(a, b, f.F);
		Console.WriteLine("Iter        a         b         c      f(a)      f(b)      f(c)");
		// while (eps < b - a)
		while (eps < Math.Abs(f.F(x)) / m1 && iteration <= MaxIterationsCount)
		{
			x = DivideSegment(a, b, f.F);
			double fa = f.F(a);
			double fb = f.F(b);
			double fc = f.F(x);

			Console.Write($"{iteration,4} {a,8:0.0000} {b,8:0.0000} {x,8:0.0000} {fa,8:0.0000} {fb,8:0.0000} {fc,8:0.0000} ");
			if (fa * fc < 0)
			{
				Console.WriteLine("moving left");
				b = x;
			}
			else
			{
				Console.WriteLine("moving right");
				a = x;
			}

			iteration++;
		}

		Console.WriteLine($"Result = {x}");
		return x;
	}

	// Метод поділу відрізка (за методом хорд)
	private static double DivideSegment(double a, double b, Func<double, double> f)
	{
		// return a + (b - a) * 0.5; // тут звичайний поділ навпіл
		return a - f(a) * (b - a) / (f(b) - f(a));
	}

	// Умовою, за якою можна здійснити коректний вибір початкового наближення, є сталість знаку другої похідної на інтервалі [a, b]
	// Якщо ця умова не виконується, потрібно зменшити проміжок [a, b]
	private static bool EnsureCanUseSecantMethod(double a, double b, double eps, Function f)
	{
		double prevDerivative2OfX = f.SecondDerivative(a);
		double x = a + eps;
		while (x <= b)
		{
			double derivative2OfX = f.SecondDerivative(x);
			if (derivative2OfX * prevDerivative2OfX < 0)
			{
				return false;
			}

			prevDerivative2OfX = derivative2OfX;
			x += eps;
		}

		return true;
	}
}
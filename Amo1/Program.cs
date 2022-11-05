namespace Amo1
{
	internal static class Program
	{
		private static void Main()
		{
			//List<double> solutions = SimplifiedNewton(-10, 3, 0.0000007, Func16, Func16Derivative);
			double secantSolution = SecantMethod(0, 9, Math.Pow(10, -7), Func24);
		}

		private static double Func16(double x)
		{
			double xIn3 = Math.Pow(x, 3);
			return Math.Pow(Math.Cos(x), 3) + xIn3 * Math.Pow(Math.Log2(Math.Sinh(x) + Math.Cosh(x)), 3) - xIn3 - 5;
		}

		private static double Func16Derivative(double x)
		{
			double xIn3 = Math.Pow(x, 3);
			double insideLog = Math.Sinh(x) + Math.Cosh(x);
			double log = Math.Log2(insideLog);
			return 3 * Math.Pow(Math.Cos(x), 2) * (-Math.Cos(x)) +
			       xIn3 * 3 * Math.Pow(log, 2) * 1 / (double)(insideLog * Math.Log(2)) * insideLog +
			       3 * x * x + Math.Pow(log, 3)
			       - 3 * x * x;
		}

		private static double Func16SecondDerivative(double x)
		{
			double xIn3 = Math.Pow(x, 3);
			double insideLog = Math.Sinh(x) + Math.Cosh(x);
			double log = Math.Log2(insideLog);
			return 3 * Math.Pow(Math.Cos(x), 2) * (-Math.Cos(x)) +
			       xIn3 * 3 * Math.Pow(log, 2) * 1 / (double)(insideLog * Math.Log(2)) * insideLog +
			       3 * x * x + Math.Pow(log, 3)
			       - 3 * x * x;
		}

		private static double Func24(double x)
		{
			// todo
			double xIn3 = Math.Pow(x, 3);
			double cosx = Math.Cos(x);
			return xIn3 - cosx * cosx - 5 * x - 3;
		}

		private static double Func24Derivative(double x)
		{
			// todo
			double xIn3 = Math.Pow(x, 3);
			return xIn3;
		}

		// Спрощений метод Ньютона
		private static List<double> SimplifiedNewton(double a, double b, double eps, Func<double, double> func, Func<double, double> derivative)
		{
			double x = 3.14;
			double fOfX = Func16(x);
			double dOfFOfX = Func16Derivative(x);
			return null;
		}

		// Метод хорд 
		private static double SecantMethod(double a, double b, double eps, Func<double, double> f)
		{
			var iteration = 0;
			double x = DivideSegment(a, b, f);
			Console.WriteLine("Iter        a         b         c      f(a)      f(b)      f(c)");
			while (eps < b - a && iteration < 100) //Math.Abs(eps - c) < (b - a) / Math.Pow(2, k))
			{
				x = DivideSegment(a, b, f);
				double fa = f(a);
				double fb = f(b);
				double fc = f(x);

				//Console.Write($"{k}: a={start}, b={end}, c={c}, f(a)={fa}, f(b)={fb}, f(c)={fc} ");
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
				// Console.WriteLine($"b - a = {b - a}");
			}

			Console.WriteLine($"Result = {x}");
			return x;
		}

		// Метод поділу відрізка (за методом хорд)
		private static double DivideSegment(double a, double b, Func<double, double> f)
		{
			//return a + (b - a) * 0.5; - тут звичайний поділ навпіл
			return a - f(a) * (b - a) / (f(b) - f(a));
		}
	}
}
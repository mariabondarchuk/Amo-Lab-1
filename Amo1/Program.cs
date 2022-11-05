namespace Amo1
{
	internal static class Program
	{
		private static void Main()
		{
			var algorithm = new SecantAlgorithm();
			//List<double> solutions = SimplifiedNewton(-10, 3, 0.0000007, Func16, Func16Derivative);
			double secantSolution = algorithm.Run(0, 9, Math.Pow(10, -7), Functions.Func24);
		}

		// // Спрощений метод Ньютона
		// private static List<double> SimplifiedNewton(double a, double b, double eps, Func<double, double> func, Func<double, double> derivative)
		// {
		// 	double x = 3.14;
		// 	double fOfX = Func16(x);
		// 	double dOfFOfX = Func16Derivative(x);
		// 	return null;
		// }
	}
}
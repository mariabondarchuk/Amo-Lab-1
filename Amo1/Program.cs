namespace Amo1
{
	internal static class Program
	{
		private static void Main()
		{
			Console.WriteLine("Виберіть алгоритм:");
			Console.WriteLine("1 - Метод хорд");
			Console.WriteLine("2 - Спрощений метод Ньютона");
			ConsoleKeyInfo input = Console.ReadKey();
			Console.WriteLine();
			if (input.Key == ConsoleKey.D1)
			{
				var algorithm = new SecantAlgorithm();
				double secantSolution = algorithm.Run(0, 9, Math.Pow(10, -7), Functions.Func24);
				Console.WriteLine($"Result = {secantSolution}");

			}
			else if (input.Key == ConsoleKey.D2)
			{
				// todo: Замінити на функцію 16
				var algorithm = new SimplifiedNewtonAlgorithm();
				double simpleNewtonSolution = algorithm.Run(0, 9, Math.Pow(10, -7), Functions.Func24);
				Console.WriteLine($"Result = {simpleNewtonSolution}");
			}
			else
			{
				Console.WriteLine("Wrong input. Bye");
			}
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
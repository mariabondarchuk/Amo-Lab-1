using System.Diagnostics;
using Amo1.Helpers;

namespace Amo1;

public class SimplifiedNewtonAlgorithm : IAlgorithm
{
	public int MaxIterationsCount => 100_0;

	public double Run(double a, double b, double eps, Function f)
	{
		double m1 = f.GetDerivativeMin(a, b, eps);
		Console.WriteLine($"m1 = {m1}");

		var iteration = 0;
		double x = GetStartX(a, b, f);
		double terminationValue = Math.Abs(f.F(x)) / m1;
		double derivativeOfX0 = f.Derivative(x);
		Console.WriteLine("Iter            x            t");
		double doubleEps = eps * eps;
		while (eps < terminationValue && iteration <= MaxIterationsCount)
		{
			Console.WriteLine($"{iteration,4} {x,8:0.00000000} {terminationValue,8:0.00000000}");
			x -= f.F(x) / derivativeOfX0;
			double prevTerminationValue = terminationValue;
			terminationValue = Math.Abs(f.F(x)) / m1;
			if (Math.Abs(prevTerminationValue - terminationValue) < doubleEps)
			{
				ConsoleHelper.WriteLineWarning("No termination condition change. Exiting");
				break;
			}

			iteration++;
		}

		if (MaxIterationsCount <= iteration)
		{
			ConsoleHelper.WriteLineWarning("Max iterations count exceeded");
		}

		return x;
	}

	// За початкове наближення х0 вибирають той кінець відрізка [a, b], якому відповідає
	// ордината такого самого знаку, що й знак f''(x), тобто f(x0)f''(x0) > 0
	private static double GetStartX(double a, double b, Function f)
	{
		if (f.F(a) * f.SecondDerivative(a) > 0)
		{
			return a;
		}

		Debug.Assert(f.F(b) * f.SecondDerivative(b) > 0);
		return b;
	}
}
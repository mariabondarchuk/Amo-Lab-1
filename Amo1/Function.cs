namespace Amo1;

public class Function
{
	public Func<double, double> F { get; init; } = null!;

	public Func<double, double> Derivative { get; init; } = null!;

	public Func<double, double> SecondDerivative { get; init; } = null!;

	// Так робити не зовсім правильно, оскільки ми проходимо весь інтервал і за цю ж "ціну" можемо просто знайти корінь рівння перебором

	public double GetDerivativeMin(double a, double b, double eps)
	{
		double x = a;
		double min = Math.Abs(Derivative(x));
		while (x <= b)
		{
			double derivative = Math.Abs(Derivative(x));
			if (derivative < min)
			{
				min = derivative;
			}

			x += eps;
		}

		return min;
	}
}
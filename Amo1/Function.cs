namespace Amo1;

public class Function
{
	public Func<double, double> F { get; init; } = null!;

	public Func<double, double> Derivative { get; init; } = null!;

	public Func<double, double> SecondDerivative { get; init; } = null!;
}
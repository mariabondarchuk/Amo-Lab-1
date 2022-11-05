namespace Amo1;

public interface IAlgorithm
{
	int MaxIterationsCount { get; }
	
	double Run(double a, double b, double eps, Function f);
}
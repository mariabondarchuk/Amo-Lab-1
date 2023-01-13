using System.Text;

namespace Amo1
{
    internal static class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Виберіть алгоритм:");
            Console.WriteLine("1 - Метод хорд");
            Console.WriteLine("2 - Спрощений метод Ньютона");
            ConsoleKeyInfo input = Console.ReadKey();
            Console.WriteLine();
            if (input.Key == ConsoleKey.D1)
            {
                var algorithm = new SecantAlgorithm();
                double secantSolutionRoot1 = algorithm.Run(-2, -1.5, Math.Pow(10, -7), Functions.Func24);
                double secantSolutionRoot2 = algorithm.Run(-1, -0.5, Math.Pow(10, -7), Functions.Func24);
                double secantSolutionRoot3 = algorithm.Run(2, 3, Math.Pow(10, -7), Functions.Func24);
                Console.WriteLine($"Корінь 1 = {secantSolutionRoot1}");
                Console.WriteLine($"Корінь 2 = {secantSolutionRoot2}");
                Console.WriteLine($"Корінь 3 = {secantSolutionRoot3}");
            }
            else if (input.Key == ConsoleKey.D2)
            {
                var algorithm = new SimplifiedNewtonAlgorithm();
                double simpleNewtonSolution1 = algorithm.Run(-1.1, -0.9, Math.Pow(10, -7), Functions.Func16);
                double simpleNewtonSolution2 = algorithm.Run(1, 1.2, Math.Pow(10, -7), Functions.Func16);
                Console.WriteLine($"Корінь 1 = {simpleNewtonSolution1}");
                Console.WriteLine($"Корінь 2 = {simpleNewtonSolution2}");
            }
            else
            {
                Console.WriteLine("Wrong input. Bye");
            }
        }
    }
}
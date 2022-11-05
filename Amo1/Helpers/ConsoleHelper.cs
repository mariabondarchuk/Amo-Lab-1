namespace Amo1.Helpers;

public class ConsoleHelper
{
	public static void WriteLineWarning(string message)
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine(message);
		Console.ResetColor();
	}
}


namespace ComputerWorld.wit.exports.example.calculator;

public class OperationsImpl : IOperations
{
    public static int Add(int left, int right)
    {
        return left + right;
    }

	public static List<string> ToUpper(List<string> input)
	{
		return input.Select(token => token.ToUpperInvariant()).ToList();
	}
}

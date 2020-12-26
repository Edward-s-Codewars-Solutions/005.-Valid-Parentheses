using System.Linq;

public static class Parentheses
{
    private const int MaxInputLength = 100;

    public static bool ValidParentheses(string input)
    {
        return input switch
        {
            var inp
                when inp.Length > MaxInputLength
                    => false,
            var inp => DoesEachParenHaveItsPair(inp)
        };
    }

    public static bool DoesEachParenHaveItsPair(string input)
    {
        var parensCollection = input
            .ToCharArray()
            .Where(x => (x == '(' || x == ')'));

        var parensString = string.Join("", parensCollection);

        bool continueLoop;

        do
        {
            int parensStringLength = parensString.Length;
            parensString = parensString.Replace("()", default);
            continueLoop = parensString.Length != parensStringLength;
        } while (continueLoop);

        return string.IsNullOrEmpty(parensString);
    }
}
using System;

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


        throw new NotImplementedException();
    }
}
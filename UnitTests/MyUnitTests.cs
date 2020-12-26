using NUnit.Framework;
using System.Collections.Generic;

public class MyUnitTests
{
    private static IEnumerable<TestCaseData> TestDataWitParens
    {
        get
        {
            yield return new TestCaseData(")(").Returns(false);
            yield return new TestCaseData("(").Returns(false);
            yield return new TestCaseData("(()").Returns(false);
            yield return new TestCaseData(")").Returns(false);
            yield return new TestCaseData("").Returns(true);
            yield return new TestCaseData("()").Returns(true);
            yield return new TestCaseData("()()").Returns(true);
            yield return new TestCaseData("(())").Returns(true);
            yield return new TestCaseData("(abcd)(@#%$)").Returns(true);
        }
    }

    [Test, TestCaseSource("TestDataWithParens")]
    public bool Are_parens_paired_correctly(string input) =>
        Parentheses.DoesEachParenHaveItsPair(input);
}
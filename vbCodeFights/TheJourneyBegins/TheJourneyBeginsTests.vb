Imports NUnit.Framework

<TestFixture()> Public Class TheJourneyBeginsTests
    ' <summary>
    ' Write a Function that returns the sum Of two numbers.
    ' Example
    ' For param1 = 1 And param2 = 2, the output should be
    ' add(param1, param2) = 3.
    ' </summary>
    ' <param name="param1"></param>
    ' <param name="param2"></param>
    ' <returns></returns>
    <Test()>
    <TestCase(1, 2, 3)>
    Public Sub add(param1 As Integer, param2 As Integer, expected As Integer)
        Dim result = (param1 + param2)
        Debug.Assert(result = expected)
    End Sub
    ' Given the string, check if it Is a palindrome.
    ' Example
    ' For inputString = "aabaa", the output should be
    ' checkPalindrome(inputString) = true;
    ' For inputString = "abac", the output should be
    ' checkPalindrome(inputString) = false;
    ' For inputString = "a", the output should be
    ' checkPalindrome(inputString) = true.
    <Test()>
    <TestCase(1700, 17)>
    <TestCase(1905, 20)>
    <TestCase(1988, 20)>
    <TestCase(2000, 20)>
    <TestCase(2001, 21)>
    Public Sub centuryFromYear(year As Integer, expected As Integer)
        Dim result As Integer = If((year Mod 100) > 0, (year / 100) + 1, (year / 100))
        Debug.Assert(result = expected)
    End Sub
    ' Given the string, check if it Is a palindrome.
    ' Example
    ' For inputString = "aabaa", the output should be
    ' checkPalindrome(inputString) = true;
    ' For inputString = "abac", the output should be
    ' checkPalindrome(inputString) = false;
    ' For inputString = "a", the output should be
    ' checkPalindrome(inputString) = true.
    <Test()>
    <TestCase("aabaa", True)>
    <TestCase("abac", False)>
    <TestCase("a", True)>
    <TestCase("az", False)>
    <TestCase("abacaba", True)>
    Public Sub checkPalindrome(inputString As String, expected As Boolean)
        Dim result As Boolean = If(inputString = New String(inputString.ToCharArray().Reverse().ToArray()), True, False)
        Debug.Assert(result = expected)
    End Sub
End Class
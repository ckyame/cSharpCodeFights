using System.Linq;

using NUnit.Framework;

namespace cSharpCodeFights.TheJourneyBegins
{
    [TestFixture]
    public class TheJourneyBegins
    {
        /// <summary>
        /// Write a function that returns the sum of two numbers.
        /// Example
        /// For param1 = 1 and param2 = 2, the output should be
        /// add(param1, param2) = 3.
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        [Test]
        [TestCase(1, 2, 3)]
        public void add(int param1, int param2, int expected)
        {
            int result = param1 + param2;
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, the second - from the year 101 up to and including the year 200, etc.
        /// Example
        /// For year = 1905, the output should be
        /// centuryFromYear(year) = 20;
        /// For year = 1700, the output should be
        /// centuryFromYear(year) = 17.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        [Test]
        [TestCase(1905, 20)]
        [TestCase(1700, 17)]
        [TestCase(1988, 20)]
        [TestCase(2000, 20)]
        [TestCase(2001, 21)]
        public void centuryFromYear(int year, int expected)
        {
            int result = (year % 100) > 0 ? (year / 100) + 1 : (year / 100);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Given the string, check if it is a palindrome.
        /// Example
        /// For inputString = "aabaa", the output should be
        /// checkPalindrome(inputString) = true;
        /// For inputString = "abac", the output should be
        /// checkPalindrome(inputString) = false;
        /// For inputString = "a", the output should be
        /// checkPalindrome(inputString) = true.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        [Test]
        [TestCase("aabaa", true)]
        [TestCase("abac", false)]
        [TestCase("a", true)]
        [TestCase("az", false)]
        [TestCase("abacaba", true)]
        public void checkPalindrome(string inputString, bool expected)
        {
            bool result = inputString == new string(inputString.ToCharArray().Reverse().ToArray());
            Assert.AreEqual(expected, result);
        }
    }
}

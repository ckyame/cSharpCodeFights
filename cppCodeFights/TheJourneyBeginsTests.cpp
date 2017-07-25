#include "stdafx.h"
#include "CppUnitTest.h"

#include "TheJourneyBegins.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace cppCodeFights
{		
	TEST_CLASS(TheJourneyBeginsTests)
	{
		TheJourneyBegins Journey;
	public:
		/// Write a function that returns the sum of two numbers.
		/// Example
		/// For param1 = 1 and param2 = 2, the output should be
		/// add(param1, param2) = 3.
		TEST_METHOD(add)
		{
			int test1Param1 = 1, test1Param2 = 2, test1Expected = 3;
			int test1Result = Journey.add(test1Param1, test1Param2);
			Assert::AreEqual(test1Expected, test1Result);
			int test2Param1 = 0, test2Param2 = 2, test2Expected = 2;
			int test2Result = Journey.add(test2Param1, test2Param2);
			Assert::AreEqual(test2Expected, test2Result);
			int test3Param1 = 1, test3Param2 = 0, test3Expected = 1;
			int test3Result = Journey.add(test3Param1, test3Param2);
			Assert::AreEqual(test3Expected, test3Result);

		}
		/// Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, the second - from the year 101 up to and including the year 200, etc.
		/// Example
		/// For year = 1905, the output should be
		/// centuryFromYear(year) = 20;
		/// For year = 1700, the output should be
		/// centuryFromYear(year) = 17.
		TEST_METHOD(centuryFromYear) 
		{
			int test1Param1 = 1700, test1Expected = 17;
			int test1Result = Journey.centuryFromYear(test1Param1);
			Assert::AreEqual(test1Expected, test1Result);
			int test2Param1 = 1905, test2Expected = 20;
			int test2Result = Journey.centuryFromYear(test2Param1);
			Assert::AreEqual(test2Expected, test2Result);
			int test3Param1 = 1988, test3Expected = 20;
			int test3Result = Journey.centuryFromYear(test3Param1);
			Assert::AreEqual(test3Expected, test3Result);
			int test4Param1 = 2000, test4Expected = 20;
			int test4Result = Journey.centuryFromYear(test4Param1);
			Assert::AreEqual(test4Expected, test4Result);
			int test5Param1 = 2001, test5Expected = 21;
			int test5Result = Journey.centuryFromYear(test5Param1);
			Assert::AreEqual(test5Expected, test5Result);
		}
		/// Given the string, check if it is a palindrome.
		/// Example
		/// For inputString = "aabaa", the output should be
		/// checkPalindrome(inputString) = true;
		/// For inputString = "abac", the output should be
		/// checkPalindrome(inputString) = false;
		/// For inputString = "a", the output should be
		/// checkPalindrome(inputString) = true.
		TEST_METHOD(checkPalindrome) 
		{
			string test1Param1 = "a";
			bool test1Expected = true;
			bool test1Result = Journey.checkPalindrome(test1Param1);
			Assert::AreEqual(test1Expected, test1Result);
			string test2Param1 = "aabaa";
			bool test2Expected = true;
			bool test2Result = Journey.checkPalindrome(test2Param1);
			Assert::AreEqual(test2Expected, test2Result);
			string test3Param1 = "abac";
			bool test3Expected = false;
			bool test3Result = Journey.checkPalindrome(test3Param1);
			Assert::AreEqual(test3Expected, test3Result);
			string test4Param1 = "abacaba";
			bool test4Expected = true;
			bool test4Result = Journey.checkPalindrome(test4Param1);
			Assert::AreEqual(test4Expected, test4Result);
			string test5Param1 = "az";
			bool test5Expected = false;
			bool test5Result = Journey.checkPalindrome(test5Param1);
			Assert::AreEqual(test5Expected, test5Result);
		}
	};
}
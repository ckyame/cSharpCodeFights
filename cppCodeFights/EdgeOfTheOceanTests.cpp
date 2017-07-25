#include "stdafx.h"
#include "CppUnitTest.h"

#include <vector>

#include "EdgeOfTheOcean.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;
using namespace std;

namespace cppCodeFights
{
	TEST_CLASS(EdgeOfTheOceanTests)
	{
		EdgeOfTheOcean Ocean;
	public:
		/// Write a function that returns the sum of two numbers.
		/// Example
		/// For param1 = 1 and param2 = 2, the output should be
		/// add(param1, param2) = 3.
		TEST_METHOD(adjacentElementsProduct)
		{
			vector<int> test1Vector = { 3, 6, -2, -5, 7, 3 };
			int expectedTest1Result = 21;
			int test1Result = Ocean.adjacentElementsProduct(test1Vector);
			Assert::AreEqual(expectedTest1Result, test1Result);
			Logger::WriteMessage("Test 1 " + (expectedTest1Result == test1Result));
			vector<int> test2Vector = { -1, -2 };
			int expectedTest2Result = 2;
			int test2Result = Ocean.adjacentElementsProduct(test2Vector);
			Assert::AreEqual(expectedTest2Result, test2Result);
			Logger::WriteMessage("Test 2 " + (expectedTest2Result == test2Result));
			vector<int> test3Vector = { 5, 1, 2, 3, 1, 4 };
			int expectedTest3Result = 6;
			int test3Result = Ocean.adjacentElementsProduct(test3Vector);
			Assert::AreEqual(expectedTest3Result, test3Result);
			Logger::WriteMessage("Test 3 " + (expectedTest3Result == test3Result));
			vector<int> test4Vector = { 9, 5, 10, 2, 24, -1, -48 };
			int expectedTest4Result = 50;
			int test4Result = Ocean.adjacentElementsProduct(test4Vector);
			Assert::AreEqual(expectedTest4Result, test4Result);
			Logger::WriteMessage("Test 4 " + (expectedTest4Result == test4Result));
		}
	};
}
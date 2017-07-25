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
		/// Below we will define an n-interesting polygon. 
		/// Your task is to find the area of a polygon for a given n.
		/// A 1-interesting polygon is just a square with a side of length 1. 
		/// An n-interesting polygon is obtained by taking the n - 1-interesting polygon 
		/// and appending 1-interesting polygons to its rim, side by side.
		TEST_METHOD(shapeArea) 
		{
			int test1 = 2;
			int expected1 = 5;
			int test1Result = Ocean.shapeArea(test1);
			Assert::AreEqual(expected1, test1Result);
			int test2 = 3;
			int expected2 = 13;
			int test2Result = Ocean.shapeArea(test2);
			Assert::AreEqual(expected2, test2Result);
			int test3 = 1;
			int expected3 = 1;
			int test3Result = Ocean.shapeArea(test3);
			Assert::AreEqual(expected3, test3Result);
			int test4 = 5;
			int expected4 = 41;
			int test4Result = Ocean.shapeArea(test4);
			Assert::AreEqual(expected4, test4Result);
		}
	};
}
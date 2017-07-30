#include <vector>

#pragma once

class EdgeOfTheOcean
{
public:
	EdgeOfTheOcean();
	~EdgeOfTheOcean();
public:
	int adjacentElementsProduct(std::vector<int> inputArray);
	int shapeArea(int n);
	int makeArrayConsecutive2(std::vector<int> statues);
	bool almostIncreasingSequence(std::vector<int> s);
	int matrixElementsSum(std::vector<std::vector<int>> matrix);
};


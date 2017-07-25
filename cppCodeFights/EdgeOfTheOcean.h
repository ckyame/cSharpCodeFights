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
	int makeArrayConsecutive2(int statues[]);
	bool almostIncreasingSequence(int s[]);
	int matrixElementsSum(std::vector<std::vector<int>> matrix);

};


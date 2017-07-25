#include "stdafx.h"
#include "EdgeOfTheOcean.h"
#include <math.h>

EdgeOfTheOcean::EdgeOfTheOcean()
{
}


EdgeOfTheOcean::~EdgeOfTheOcean()
{
}

int EdgeOfTheOcean::adjacentElementsProduct(std::vector<int> ia)
{
	int m = ia[0] * ia[1];
	for (int i = 1; i<ia.size() - 1; i++) {
		int p = ia[i] * ia[i + 1];
		if (p>m)
			m = p;
	}
	return m;
}

int EdgeOfTheOcean::shapeArea(int n) 
{
	return (n == 1) ? 1 : pow(n, 2) + pow(n - 1, 2);
}
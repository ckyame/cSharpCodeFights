#include "stdafx.h"
#include "EdgeOfTheOcean.h"


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
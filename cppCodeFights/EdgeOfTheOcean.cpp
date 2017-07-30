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

int EdgeOfTheOcean::makeArrayConsecutive2(std::vector<int> s)
{
	int c = s[0];
	int r = 0;
	for (int i = 0; i < s.size; i++) 
	{
		r += (s[i] - c > 1) ? (s[i] - c) - 1 : 0;
		c = s[i];
	}
	return r;
}

bool EdgeOfTheOcean::almostIncreasingSequence(std::vector<int> s)
{
	bool f = false;
	bool d = false;
	for (int i = -1, j = 0, k = 1; k < s.size; k++)
	{
		d = false;
		if (s[j] >= s[k])
		{
			if (f)
				return false;
			f = true;
			if (k > 1 && s[i] >= s[k])
				d = true;
		}
		if (!f)
			i = j;
		if (!d)
			j = k;
	}
	return true;
}


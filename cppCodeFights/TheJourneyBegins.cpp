#include "stdafx.h"
#include "TheJourneyBegins.h"

int TheJourneyBegins::add(int param1, int param2) 
{
	return param1 + param2;
}

int TheJourneyBegins::centuryFromYear(int year) 
{
	return (year % 100) > 0 ? (year / 100) + 1 : (year / 100);
}

bool TheJourneyBegins::checkPalindrome(string inputString)
{
	string temp = inputString;
	std::reverse(inputString.begin(), inputString.end());
	return temp == inputString;
}
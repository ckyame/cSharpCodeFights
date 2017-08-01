import unittest

from TheJourneyBegins import *

class Test_TheJourneyBeginsTests(unittest.TestCase):
    Journey = TheJourneyBegins()

    def test_add(self):
        result = self.Journey.add(1, 2)
        self.assertEqual(3, result, 0)

    def test_centuryFromYear(self):
        year = 1905
        expected = 20
        result =  (year / 100) + 1 if (year % 100) > 0 else (year/100) 
        self.assertEqual(expected, int(result), 1)

if __name__ == '__main__':
    unittest.main()



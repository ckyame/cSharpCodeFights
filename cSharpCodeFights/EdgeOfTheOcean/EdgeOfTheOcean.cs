using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpCodeFights.EdgeOfTheOcean
{
    public class EdgeOfTheOcean
    {
        public int adjacentElementsProduct(int[] inputArray)
        {
            int a = inputArray[0], 
                b = inputArray[1], 
                c = inputArray[0] * inputArray[1];
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (c <= inputArray[i] * inputArray[i + 1])
                {
                    a = inputArray[i];
                    b = inputArray[i + 1];
                    c = inputArray[i] * inputArray[i + 1];
                }
            }
            return c;
        }

        public int shapeArea(int n)
        {
            return (n == 1) 
                ? 1 
                : Convert.ToInt32(
                    Math.Pow(n, 2) 
                  + Convert.ToInt32(
                      Math.Pow(n - 1, 2)));
        }

        public int makeArrayConsecutive2(int[] statues)
        {
            Array.Sort(statues);
            int c = statues[0];
            int r = 0;
            for (int i = 0; i < (statues.Length); i++)
            {
                r += (statues[i] - c > 1) ? (statues[i] - c) - 1 : 0;
                c = statues[i];
            }
            return r;
        }

        public bool almostIncreasingSequence(int[] s)
        {
            bool f = false;
            bool d = false;
            for (int i = -1, j = 0, k = 1; k < s.Length; k++)
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

        public int matrixElementsSum(int[][] matrix)
        {
            int total = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                try
                {
                    for (int col = 0; col < matrix[row].GetLength(0); col++)
                    {
                        if (row == 0)
                        {
                            total += matrix[row][col];
                        }
                        else
                        {
                            if (matrix[row - 1][col] != 0)
                            {
                                if (row - 2 > -1)
                                {
                                    if (matrix[row - 2][col] != 0)
                                        total += matrix[row][col];
                                }
                                else
                                {
                                    total += matrix[row][col];
                                }

                            }
                        }
                    }
                }
                catch (Exception) { }
            }
            return total;
        }

    }
}

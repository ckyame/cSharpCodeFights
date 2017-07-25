using NUnit.Framework;
using System;
using System.Linq;

namespace cSharpCodeFights.EdgeOfTheOcean
{
    [TestFixture]
    public class EdgeOfTheOceanTests
    {
        #region Fields

        public EdgeOfTheOcean Ocean;

        #endregion

        #region Setup 

        [TestFixtureSetUp]
        public void EdgeOfTheOceanSetup()
        {
            Ocean = new EdgeOfTheOcean();
        }

        #endregion

        /// <summary>
        /// Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
        /// Example
        /// For inputArray = [3, 6, -2, -5, 7, 3], the output should be
        /// adjacentElementsProduct(inputArray) = 21.
        /// 7 and 3 produce the largest product.
        /// </summary>
        [Test]
        [TestCase(new[] { 3, 6, -2, -5, 7, 3 }, 21)]
        [TestCase(new[] { -1, -2 }, 2)]
        [TestCase(new[] { 5, 1, 2, 3, 1, 4 }, 6)]
        [TestCase(new[] { 1, 2, 3, 0 }, 6)]
        [TestCase(new[] { 9, 5, 10, 2, 24, -1, -48 }, 50)]
        [TestCase(new[] { 5, 6, -4, 2, 3, 2, -23 }, 30)]
        [TestCase(new[] { 4, 1, 2, 3, 1, 5 }, 6)]
        [TestCase(new[] { -23, 4, -3, 8, -12 }, -12)]
        [TestCase(new[] { 1, 0, 1, 0, 1000 }, 0)]
        public void adjacentElementsProduct(int[] x, int expected)
        {
            int result = Ocean.adjacentElementsProduct(x);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Below we will define an n-interesting polygon. 
        /// Your task is to find the area of a polygon for a given n.
        /// A 1-interesting polygon is just a square with a side of length 1. 
        /// An n-interesting polygon is obtained by taking the n - 1-interesting polygon 
        /// and appending 1-interesting polygons to its rim, side by side.
        /// </summary>
        [Test]
        [TestCase(2, 5)]
        [TestCase(3, 13)]
        [TestCase(1, 1)]
        [TestCase(5, 41)]
        public void shapeArea(int n, int expected)
        {
            int result = Ocean.shapeArea(n);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, 
        /// each statue having an non-negative integer size. Since he likes to make things perfect, 
        /// he wants to arrange them from smallest to largest so that each statue will be bigger 
        /// than the previous one exactly by 1. He may need some additional statues to be able to 
        /// accomplish that. Help him figure out the minimum number of additional statues needed.
        /// Example
        /// For statues = [6, 2, 3, 8], the output should be
        /// makeArrayConsecutive2(statues) = 3.
        /// Ratiorg needs statues of sizes 4, 5 and 7.
        /// </summary>
        [Test]
        [TestCase(new[] { 6, 2, 3, 8 }, 3)]
        [TestCase(new[] { 0, 3 }, 2)]
        [TestCase(new[] { 5, 4, 6 }, 0)]
        [TestCase(new[] { 6, 3 }, 2)]
        [TestCase(new[] { 1 }, 0)]
        public void makeArrayConsecutive2(int[] statues, int expected)
        {
            var result = Ocean.makeArrayConsecutive2(statues);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Given a sequence of integers as an array, determine whether it is possible 
        /// to obtain a strictly increasing sequence by removing no more than one element from the array.
        /// Example
        /// For sequence = [1, 3, 2, 1], the output should be
        /// almostIncreasingSequence(sequence) = false;
        /// There is no one element in this array that can be removed in order to get a strictly increasing sequence.
        /// For sequence = [1, 3, 2], the output should be
        /// almostIncreasingSequence(sequence) = true.
        /// You can remove 3 from the array to get the strictly increasing sequence[1, 2]. 
        /// Alternately, you can remove 2 to get the strictly increasing sequence[1, 3].
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns></returns>
        [Test]
        [TestCase(new[] { 1, 3, 2, 1 }, false)]
        [TestCase(new[] { 1, 3, 2 }, true)]
        [TestCase(new[] { 1, 2, 1, 2 }, false)]
        [TestCase(new[] { 1, 4, 10, 4, 2 }, false)]
        [TestCase(new[] { 10, 1, 2, 3, 4, 5 }, true)]
        [TestCase(new[] { 1, 1, 1, 2, 3 }, false)]
        [TestCase(new[] { 0, -2, 5, 6 }, true)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 3, 5, 6 }, false)]
        [TestCase(new[] { 40, 50, 60, 10, 20, 30 }, false)]
        [TestCase(new[] { 1, 1 }, true)]
        [TestCase(new[] { 10, 1, 2, 3, 4, 5, 6, 1 }, false)]
        [TestCase(new[] { 1, 2, 3, 4, 3, 6 }, true)]
        [TestCase(new[] { 1, 2, 3, 4, 99, 5, 6 }, true)]
        [TestCase(new[] { 123, -17, -5, 1, 2, 3, 12, 43, 45 }, true)]
        [TestCase(new[] { 3, 5, 67, 98, 3 }, true)]
        public void almostIncreasingSequence(int[] sequence, bool expected)
        {
            bool result = Ocean.almostIncreasingSequence(sequence);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// After becoming famous, CodeBots decided to move to a new building and live together. 
        /// The building is represented by a rectangular matrix of rooms, each cell containing 
        /// an integer - the price of the room. Some rooms are free (their cost is 0), but that's 
        /// probably because they are haunted, so all the bots are afraid of them. That is why any 
        /// room that is free or is located anywhere below a free room in the same column is not 
        /// considered suitable for the bots.
        /// Help the bots calculate the total price of all the rooms that are suitable for them.
        /// Example
        /// For
        /// matrix = [[0, 1, 1, 2], 
        ///          [0, 5, 0, 0], 
        ///          [2, 0, 3, 3]]
        /// the output should be
        /// matrixElementsSum(matrix) = 9.
        /// Here's the rooms matrix with unsuitable rooms marked with 'x':
        /// [[x, 1, 1, 2], 
        ///  [x, 5, x, x], 
        ///  [x, x, x, x]]
        /// Thus, the answer is 1 + 5 + 1 + 2 = 9.
        /// </summary>
        [Test]
        public void matrixElementsSum()
        {
            int[][] test1 = new int[][] {
                new[] { 0, 1, 1, 2 },
                new[] { 0, 5, 0, 0 },
                new[] { 2, 0, 3, 3 } };
            int expected1 = 9;
            Assert.AreEqual(expected1, Ocean.matrixElementsSum(test1));
            int[][] test2 = new int[][] {
                new[] { 1, 1, 1, 0},
                new[] { 0, 5, 0, 1},
                new[] { 2, 1, 3, 10 } };
            int expected2 = 9;
            Assert.AreEqual(expected2, Ocean.matrixElementsSum(test2));
            int[][] test3 = new int[][] {
                new[] { 1, 1, 1 },
                new[] { 2, 2, 2 },
                new[] { 3, 3, 3 } };
            int expected3 = 18;
            Assert.AreEqual(expected3, Ocean.matrixElementsSum(test3));
            int[][] test4 = new int[][] { new[] { 0 } };
            int expected4 = 0;
            Assert.AreEqual(expected4, Ocean.matrixElementsSum(test4));
        }
    }
}

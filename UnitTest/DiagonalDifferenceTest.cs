using System.Collections.Generic;

namespace UnitTest
{
    public class DiagonalDifferenceTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public static void Test1(List<List<int>> values, int expected)
        {
            Assert.Equal(expected, Matrix.DiagonalDifference(values));
        }

        static IEnumerable<Object> Data() 
        {
            yield return new Object[] 
            {
                new List<List<int>> 
                {
                    new List<int> {3},
                    new List<int> {1,2,3},
                    new List<int> {4,5,6},
                    new List<int> {9,8,9}
                },
                2
            };

            yield return new Object[]
            {
                new List<List<int>>
                {
                    new List<int> {3},
                    new List<int> {11,2,  4},
                    new List<int> {4, 5,  6},
                    new List<int> {10,8,-12}
                }, 
                15
            };

            yield return new Object[] 
            {
                new List<List<int>>
                {
                    new List<int> {4},
                    new List<int> {-1,  1,-7,-8},
                    new List<int> {-10,-8,-5,-2},
                    new List<int> {  9, 9, 7,-1},
                    new List<int> {  4, 4,-2, 1}
                }, 
                1
            };
        }
    }
}
using System.Collections.Generic;

namespace UnitTest
{
    public class LonelyIntegerTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Test1(List<int> values, int expected)
        {
            Assert.Equal(expected, LonelyInteger.SearchLonlyInteger(values));
        }

        public static IEnumerable<Object> Data()
        {
            yield return new Object[] { new List<int> { 1, 2, 3, 2, 1 }, 3 };
            yield return new Object[] { new List<int> { 2, 3, 2 }, 3 };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTest
{
    public class OrdreAlphaTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Test1(List<List<char>> array, string resultExpected)
        {
            Assert.Equal(OrdreAlpha.GridChallenge(array), resultExpected);
        }

        public static IEnumerable<Object> Data()
        {
            yield return new Object[] {
                new List<List<char>>
                {
                    new List<char> { 'a', 'b', 'c' },
                    new List<char> { 'e', 'f', 'g' }
                }, "yes"
            };

            yield return new Object[] 
            {
                new List<List<char>>
                {
                    new List<char> { 'a', 'f', 'c' },
                    new List<char> { 'e', 'b', 'g' }
                }, "no"
            };
        }
    }
}
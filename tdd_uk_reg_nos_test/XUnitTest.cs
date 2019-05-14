using System;
using System.Linq;
using Xunit;

namespace tdd_uk_reg_nos_test
{
    public class XUnitTest
    {
        [Fact]
        public void simple_invariant()
        {
            Assert.Equal(4, addNumbers(2, 2));
        }

        int     addNumbers( int x, int y )
        {
            return x + y;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public  void    simple_theory( int value )
        {
            Assert.True(isOdd(value));
        }

        bool    isOdd( int value )
        {
            return value % 2 == 1;
        }
    }
}

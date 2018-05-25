using System;
using Xunit;

namespace WiskLibTests
{
    public class WiskLibTests
    {
        [Fact]
        public void SqShouldReturnSquare()
        {
            Assert.Equal(4, WiskLib.WiskLib.Sq(2));
            Assert.Equal(9, WiskLib.WiskLib.Sq(3));
        }

        [Fact]
        public void ConstrainShouldConstrainInputValue()
        {
            Assert.Equal(4, WiskLib.WiskLib.Constrain(4, 0, 10));
            Assert.Equal(5, WiskLib.WiskLib.Constrain(4, 5, 10));
            Assert.Equal(12, WiskLib.WiskLib.Constrain(12, 5, 12));
        }
    }
}

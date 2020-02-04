using Palandrome;
using System;
using Xunit;

namespace PaladromeUnitTest

{
    public class PallindromeTest
    {
        [Fact]
        public void Arthemtictest() {
            Assert.Equal(1, 1);
        }
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd or even")]
        [InlineData("")]
        public void IsPallindrome(string a)
        {
            Assert.True(Palandrome.Palandrome.TestPalandrome(a));
        }
        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void NotPallindrome(string a)
        {
            Assert.False(Palandrome.Palandrome.TestPalandrome(a));
        }

    }
}


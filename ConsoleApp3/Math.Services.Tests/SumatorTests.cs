using Xunit;

namespace Math.Services.Tests
{
    public class SumatorTests
    {
        [Theory]
        [InlineData(null,   0)]
        [InlineData("",     0)]
        [InlineData("-1",   -1)]
        [InlineData("0",    0)]
        [InlineData("1",    1)]
        [InlineData("1,2,3",     6)]
        [InlineData("1 , 2 , 3 ",    6)]
        [InlineData("1 , -2 , 3 ",   2)]
        [InlineData("1 ,  , 3 ",    4)]
        [InlineData("1,2,3,4",  10)]
        [InlineData("1,2,kuba,3,4", 10)]
        public void FromCsv_VariousInput_Valid(string input, int expected)
        {
            // Act
            var actual = Sumator.FromCsv(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

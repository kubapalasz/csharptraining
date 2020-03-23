using Xunit;

namespace Math.Services.Tests
{
    public class LargestNumberTests
    {
        [Theory]
        [InlineData(new[] {"1", "5", "7"}, "7")]
        [InlineData(new[] {"54", "1", "0"}, "54")]
        [InlineData(new[] {"-5", "6", "-4"}, "6")]
        [InlineData(new[] {"-54", "-7", "-8"}, "-7")]
        [InlineData(new[] {"12", "15", " 8 "}, "15")]
        [InlineData(new[] {"12"}, "12")]
        [InlineData(new[] {"12", "", "46"}, "46")]
        [InlineData(new[] {"12", "  ", "25"}, "25")]
        [InlineData(new[] {"12", null}, "12")]
        [InlineData(new[] {""}, "")]
        [InlineData(new[] {"test"}, "")]
        [InlineData(null, "")]
        [InlineData(new[] {"ciag-znakow-nie-bedacy-liczba"}, "")]
        [InlineData(new[] {"1.0"}, "")]
        [InlineData(new[] {"1.2"}, "")]
        [InlineData(new[] {"1.333333"}, "")]
        [InlineData(new[] { "1,0" }, "")]
        [InlineData(new[] { "1 0" }, "")]
        public void MaxFromAray_VariousInput_Valid(string[] input, string expected)
        {
            // Act
            var actual = LargestNumber.MaxFromArray(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace Math.Services.Tests
{
    public class ElimaneOddNumbersTests
    {
        [Theory]
        [InlineData(new[] {"1", "5", "7"}, "")]
        [InlineData(new[] {"54", "1", "0"}, "54, 0")]
        [InlineData(new[] {"-5", "6", "-4"}, "6, -4")]
        [InlineData(new[] {"-54", "-7", "-8"}, "-54, -8")]
        [InlineData(new[] {"12", "15", " 8 "}, "12, 8")]
        [InlineData(new[] {"12"}, "12")]
        [InlineData(new[] {"12", "", "46"}, "12, 46")]
        [InlineData(new[] {"12", "  ", "25"}, "12")]
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
            var actual = ElimanteOddNumbers.RemoveOddNumbers(input?.ToList());

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

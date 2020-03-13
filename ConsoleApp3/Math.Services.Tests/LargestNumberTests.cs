using Xunit;

namespace Math.Services.Tests
{
    public class LargestNumberTests
    {
        [Theory]
        [InlineData(new[] {"1","5","7"}, "7")]
        [InlineData(new[] {"54","1","0"}, "54")]        
        [InlineData(new[] {"-5","6","-4"}, "6")]        
        [InlineData(new[] {"-54","-7","-8"}, "-7")]        
        [InlineData(new[] {"12","15", " 8 "}, "15")]        
        [InlineData(new[] {"12"}, "12")]        
        public void MaxFromAray_VariousInput_Valid(string[] input, string expected)
        {
            // Act
            var actual = LargestNumber.MaxFromArray(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

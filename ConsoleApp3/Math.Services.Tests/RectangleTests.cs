using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Math.Services.Tests
{
    public class RectangleTests
    {


        [Theory]
        public void Move_LeftFromInitial_Ok()
        {
            // Arrange
            var rectangle = new Rectangle();

            // Act
            rectangle.Move(ConsoleKey.LeftArrow);

            // Assert
            Assert.Equal(1, rectangle.X);
            Assert.Equal(1, rectangle.Y);
        }

    }
}

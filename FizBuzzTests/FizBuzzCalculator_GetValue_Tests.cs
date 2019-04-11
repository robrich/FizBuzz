using FizBuzzLib;
using FluentAssertions;
using Xunit;

namespace FizBuzzTests
{
    public class FizBuzzCalculator_GetValue_Tests
    {

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fiz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizBuzz")]
        public void Test_GetValue(int input, string expected)
        {
            // Arrange

            // Act
            FizBuzzCalculator calc = new FizBuzzCalculator();
            string actual = calc.GetValue(input);

            // Assert
            actual.Should().Be(expected);
        }

    }
}

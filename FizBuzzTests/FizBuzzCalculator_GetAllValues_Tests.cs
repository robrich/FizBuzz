using FizBuzzLib;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace FizBuzzTests
{
    public class FizBuzzCalculator_GetAllValues_Tests
    {

        [Fact]
        public void GetAllValues_Test()
        {
            // Arrange
            int upperBounds = 20;
            List<string> expected = new List<string>
            {
                "1", "2", "Fiz", "4", "Buzz", "Fiz", "7", "8", "Fiz", "Buzz", "11", "Fiz", "13", "14", "FizBuzz", "16", "17", "Fiz", "19", "Buzz"
            };

            // Act
            FizBuzzCalculator calc = new FizBuzzCalculator();
            IEnumerable<string> actual = calc.GetAllValues(upperBounds);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

    }
}

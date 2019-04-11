using FizBuzzLib;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace FizBuzzTests
{
    public class UserDefinedValues_Tests
    {
        
        [Fact]
        public void TestUserDefinedValues()
        {
            // Arrange
            List<(int, string)> rules = new List<(int, string)>
            {
                (8,"taco"),
                (9,"burrito")
            };
            int upperBounds = 20;
            List<string> expected = new List<string>
            {
                "1", "2", "3", "4", "5", "6", "7", "taco", "burrito", "10", "11", "12", "13", "14", "15", "taco", "17", "burrito", "19", "20"
            };
            

            // Act
            FizBuzzCalculator calc = new FizBuzzCalculator(rules);
            IEnumerable<string> actual = calc.GetAllValues(upperBounds);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

    }
}

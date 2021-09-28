using System;
using Xunit;
using Josephus;


namespace Josephus.Tests
{
    public class LastPersonStandingTest
    {
        [Fact]
        public void input_10_expected_4()
        {
            // Arrange
            int numberOfPeople = 10;
            int interval = 3;
            int expectedResult = 4;
            int actualResult;
            var unit = new SuicidePact();

            // Act
            actualResult = unit.LastPersonStanding(numberOfPeople, interval);

            // Assert
            Assert.Equal(actualResult, expectedResult);
        }

        [Theory]
        [InlineData(10,2,5),InlineData(10,3,4),InlineData(10,4,5), InlineData(10,5,3)]
        [InlineData(11,2,7),InlineData(11,3,7),InlineData(11,4,9), InlineData(11,5,8)]
        [InlineData(12,2,9),InlineData(12,3,10),InlineData(12,4,1), InlineData(12,5,1)]
        [InlineData(13,2,11),InlineData(13,3,13), InlineData(13,4,5), InlineData(13,5,6)]
        [InlineData(41,2,19),InlineData(41,3,31),InlineData(41,4,11), InlineData(41,5,21)]
        public void LastPersonStandingTheory(int numberOfPeople, int interval, int expectedResult)
        {
            // Arrange
            var unit = new SuicidePact();
            int actualResult;

            // Act
            actualResult = unit.LastPersonStanding(numberOfPeople, interval);

            // Assert
            Assert.Equal(actualResult, expectedResult);

        }
    }
}

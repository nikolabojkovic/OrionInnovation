using Xunit;
using FluentAssertions;
using OrionInnovation.Domain;
using System;

namespace OrionInnovation.UnitTests
{
    public class CountWordsTest
    {
        [Theory]
        [InlineData("Text created by Nikola Bojkovic.", 5)]
        [InlineData("Text created by Nikola Bojkovic. .", 5)]
        [InlineData("Text created by ..,$ %!@ Nikola Bojkovic. .", 5)]
        [InlineData("   Text created   by ..,$ %!@ Nikola Bojkovic. . ", 5)]
        [InlineData(" ", 0)]
        [InlineData("", 0)]
        public void CroundWords_FromText_ShouldReturnWordsCount(string text, int expectedWordsCount)
        {
            // Arrange
            var dateOfCreating = new DateTime(2020, 10, 3);
            var actualText = Text.Create(text, dateOfCreating);

            // Act
            var actualWordsCount = actualText.CountWords();

            // Assert
            actualWordsCount.Should().Be(expectedWordsCount);
        }
    }
}

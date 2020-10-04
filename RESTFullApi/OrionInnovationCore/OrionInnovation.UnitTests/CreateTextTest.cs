using Xunit;
using FluentAssertions;
using OrionInnovation.Domain;
using System;

namespace OrionInnovation.UnitTests
{
    public class CreateText
    {
        [Fact]
        public void CreateText_ShouldCreateTextObject()
        {
            // Arrange
            var expectedText = "Sample text";
            var expectedDateOfCreating = new DateTime(2020, 10, 3);

            // Act
            var actualText = Text.Create(expectedText, expectedDateOfCreating);

            // Assert
            actualText.Content.Should().Be(expectedText);
            actualText.CreatedAt .Should().Be(expectedDateOfCreating);
        }
    }
}

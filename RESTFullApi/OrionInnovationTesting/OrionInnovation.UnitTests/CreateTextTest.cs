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
            var expectedTextContent = "Sample text";
            var expectedDateOfCreating = new DateTime(2020, 10, 3);

            // Act
            var actualText = Text.Create(expectedTextContent, expectedDateOfCreating);

            // Assert
            actualText.Content.Should().Be(expectedTextContent);
            actualText.CreatedAt.Should().Be(expectedDateOfCreating);
        }
    }
}

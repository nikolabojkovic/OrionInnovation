using Xunit;
using FluentAssertions;
using OrionInnovation.Domain;

namespace OrionInnovation.UnitTests
{
    public class CreateText
    {
        [Fact]
        public void CreateText_ShouldCreateTextObject()
        {
            // Arrange
            var expectedText = "Sample text";

            // Act
            var actualText = Text.Create(expectedText);

            // Assert
            actualText.Content.Should().Be(expectedText);
        }
    }
}

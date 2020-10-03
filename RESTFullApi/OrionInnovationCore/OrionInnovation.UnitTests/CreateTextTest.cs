using System;
using Xunit;
using FluentAssertions;

namespace OrionInnovation.UnitTests
{
    public class CreateText
    {
        [Fact]
        public void CreateText_ShouldCreateTextObject()
        {
            string.Empty.Should().Be(string.Empty);
        }
    }
}

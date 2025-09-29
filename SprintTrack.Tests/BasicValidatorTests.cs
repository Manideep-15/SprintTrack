using SprintTrack.Core.Services;
using Xunit;

namespace SprintTrack.Tests.Services
{
    public class BasicValidatorTests
    {
        private readonly BasicValidator _validator = new();

        [Theory]
        [InlineData("test@example.com", true)]
        [InlineData("invalid-email", false)]
        [InlineData("", false)]
        public void IsValidEmail_ShouldValidateCorrectly(string email, bool expected)
        {
            var result = _validator.IsValidEmail(email);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Hello", true)]
        [InlineData("", false)]
        [InlineData("   ", false)]
        public void IsNonEmpty_ShouldValidateCorrectly(string input, bool expected)
        {
            var result = _validator.IsNonEmpty(input);
            Assert.Equal(expected, result);
        }
    }
}

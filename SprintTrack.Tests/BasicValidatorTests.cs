using SprintTrack.Core.Services;
using Xunit;

namespace SprintTrack.Tests.Services
{
    public class BasicValidatorTests
    {
        private readonly BasicValidator _validator = new();

        [Theory]
        [InlineData("test@example.com", true)]
        [InlineData("user.name@domain.co", true)]
        [InlineData("invalid-email", false)]
        [InlineData("", false)]
        [InlineData("   ", false)]
        public void IsValidEmail_ShouldReturnExpectedResult(string email, bool expected)
        {
            var result = _validator.IsValidEmail(email);
            Assert.Equal(expected, result.IsSuccess);
        }

        [Theory]
        [InlineData("Hello", true)]
        [InlineData("SprintTrack", true)]
        [InlineData("", false)]
        [InlineData("   ", false)]
        public void IsNonEmpty_ShouldReturnExpectedResult(string input, bool expected)
        {
            var result = _validator.IsNonEmpty(input);
            Assert.Equal(expected, result.IsSuccess);
        }

        [Theory]
        [InlineData("user_123", true)]
        [InlineData("AdminUser", true)]
        [InlineData("u", false)]
        [InlineData("user@name", false)]
        [InlineData("thisusernameiswaytoolongtobevalid", false)]
        public void IsValidUsername_ShouldReturnExpectedResult(string username, bool expected)
        {
            var result = _validator.IsValidUsername(username);
            Assert.Equal(expected, result.IsSuccess);
        }
    }
}

using SprintTrack.Core.Common;
using System.Text.RegularExpressions;

namespace SprintTrack.Core.Services
{
    public class BasicValidator : IValidator
    {
        public Result<bool> IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return Result<bool>.Failure("Email cannot be empty.");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return Result<bool>.Failure("Email format is invalid.");

            return Result<bool>.Success(true);
        }

        public Result<bool> IsNonEmpty(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return Result<bool>.Failure("Input cannot be empty.");

            return Result<bool>.Success(true);
        }

        public Result<bool> IsValidUsername(string username)
        {
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]{3,20}$"))
                return Result<bool>.Failure("Username must be 3–20 characters and alphanumeric.");

            return Result<bool>.Success(true);
        }
    }
}

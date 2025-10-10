using System;

namespace SprintTrack.Core.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public Role Role { get; private set; }

        public User(string username, string email, Role role)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required.");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required.");

            Id = Guid.NewGuid();
            Username = username;
            Email = email;
            Role = role;
        }

        public void PromoteTo(Role newRole)
        {
            Role = newRole;
        }
    }

    public enum Role
    {
        Admin,
        Manager,
        User
    }
}

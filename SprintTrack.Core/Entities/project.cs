using System;
using System.Collections.Generic;

namespace SprintTrack.Core.Entities
{
    public class Project
    {
        public Guid id;

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<Guid> MemberIds { get; private set; }

        public Project(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Project name is required.");

            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            MemberIds = new List<Guid>();
        }

        public void AddMember(Guid userId)
        {
            if (!MemberIds.Contains(userId))
                MemberIds.Add(userId);
        }

        public bool IsMember(Guid userId)
        {
            return MemberIds.Contains(userId);
        }
    }
}

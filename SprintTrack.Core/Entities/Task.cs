using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintTrack.Core.Entities
{
    public class Task
    {
        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public Guid AssignedToUserId { get; private set; }
        public Guid ProjectId { get; private set; }
        public bool IsCompleted { get; private set; }

        public Task(string description, Guid assignedToUserId, Guid projectId)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be empty.");

            Id = Guid.NewGuid();
            Description = description;                // Description must not be empty.
            AssignedToUserId = assignedToUserId;     //AssignedToUserId and ProjectId must be valid GUIDs.
            ProjectId = projectId;
            IsCompleted = false;
        }

        public void MarkComplete()
        {
            IsCompleted = true;
        }
    }
}


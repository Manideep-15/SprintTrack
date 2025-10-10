using System;
using System.Collections.Generic;

namespace SprintTrack.Core.Entities
{
    public class Task
    {
        public Guid Id { get; private set; }
        public Guid ProjectId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Guid AssigneeId { get; private set; }
        public TaskStatus Status { get; private set; }
        public TaskPriority Priority { get; private set; }
        public DateTime? DueDate { get; private set; }
        public List<string> Labels { get; private set; }
        public List<string> Attachments { get; private set; }

        public Task(Guid projectId, string title, string description, Guid assigneeId,
                    TaskPriority priority, DateTime? dueDate)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Task title is required.");

            Id = Guid.NewGuid();
            ProjectId = projectId;
            Title = title;
            Description = description;
            AssigneeId = assigneeId;
            Status = TaskStatus.Open;
            Priority = priority;
            DueDate = dueDate;
            Labels = new List<string>();
            Attachments = new List<string>();
        }

        public void AssignTo(Guid userId)
        {
            AssigneeId = userId;
        }

        public void MarkDone()
        {
            Status = TaskStatus.Done;
        }

        public void AddLabel(string label)
        {
            if (!Labels.Contains(label))
                Labels.Add(label);
        }

        public void AddAttachment(string filePath)
        {
            Attachments.Add(filePath);
        }
    }

    public enum TaskStatus
    {
        Open,
        InProgress,
        Done
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }
}

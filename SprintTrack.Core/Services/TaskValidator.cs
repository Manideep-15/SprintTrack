using System;
using SprintTrack.Core.Entities;
using Task = SprintTrack.Core.Entities.Task;

namespace SprintTrack.Core.Services
{
    public class TaskValidator : IValidator<Task>
    {
        void IValidator<Task>.Validate(Task task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            if (string.IsNullOrWhiteSpace(task.Title))
                throw new ArgumentException("Task title is required.");

            if (task.ProjectId == Guid.Empty)
                throw new ArgumentException("Project ID is required.");

            if (task.AssigneeId == Guid.Empty)
                throw new ArgumentException("Assignee ID is required.");
        }
    }
}
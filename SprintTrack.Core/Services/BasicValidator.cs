using SprintTrack.Core.Entities;
using Task = SprintTrack.Core.Entities.Task;

namespace SprintTrack.Core.Services
{
    public class TaskValidator : IValidator<Task>
    {
        public bool IsValid(Task task)
        {
            return task != null &&
                   !string.IsNullOrWhiteSpace(task.Title) &&
                   task.ProjectId != Guid.Empty &&
                   task.AssigneeId != Guid.Empty;
        }

        public void Validate(Task task)
        {
            throw new NotImplementedException();
        }
    }
}

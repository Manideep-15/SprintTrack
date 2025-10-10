using System;
using SprintTrack.Core.Common;
using SprintTrack.Core.Entities;
using Task = SprintTrack.Core.Entities.Task;


namespace SprintTrack.Core.Services
{
    public class TaskService
    {
        private readonly IIdGenerator _idGenerator;
        private readonly IValidator<Task> _validator;

        public TaskService(IIdGenerator idGenerator, IValidator<Task> validator)
        {
            _idGenerator = idGenerator;
            _validator = validator;
        }

        public Result<Task> CreateTask(Guid projectId, string title, string description, Guid assigneeId,
                                       TaskPriority priority, DateTime? dueDate)
        {
            var task = new Task(projectId, title, description, assigneeId, priority, dueDate);

            try
            {
                _validator.Validate(task);
                return Result<Task>.Success(task);
            }
            catch (Exception ex)
            {
                return Result<Task>.Failure(ex.Message);
            }
        }

        public Result<Task> MarkTaskDone(Task task)
        {
            if (task.Status == Entities.TaskStatus.Done)
                return Result<Task>.Failure("Task is already marked as done.");

            task.MarkDone();
            return Result<Task>.Success(task);
        }
    }
}

namespace SprintTrack.Core.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid AssignedToUserId { get; set; }
        public Guid ProjectId { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string description, Guid assignedToUserId, Guid projectId)
        {
            Id = Guid.NewGuid();
            Description = description;
            AssignedToUserId = assignedToUserId;
            ProjectId = projectId;
            IsCompleted = false;
        }

        public void MarkComplete() => IsCompleted = true;
    }
}

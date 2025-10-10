using SprintTrack.Core.Entities;
using Task = SprintTrack.Core.Entities.Task;


Console.WriteLine("SprintTrack Playground");

var task = new Task(Guid.NewGuid(), "Design UI", "Create dashboard layout", Guid.NewGuid(), TaskPriority.High, DateTime.Today.AddDays(5));
task.MarkDone();

Console.WriteLine($"Task: {task.Title}, Status: {task.Status}");

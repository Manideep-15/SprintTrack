using SprintTrack.Core.Entities;
using SprintTrack.Core.Repositories;
using SprintTrack.Infrastructure.Repositories;
using Xunit;

namespace SprintTrack.Tests.Repositories
{
    public class InMemoryTaskRepositoryTests
    {
        [Fact]
        public void AddAndGetTask_ShouldSucceed()
        {
            var repo = new InMemoryTaskRepository();
            var task = new TaskItem("Test Task", Guid.NewGuid(), Guid.NewGuid());

            repo.Add(task);
            var fetched = repo.GetById(task.Id);

            Assert.NotNull(fetched);
            Assert.Equal("Test Task", fetched.Description);
        }

        [Fact]
        public void UpdateTask_ShouldModifyData()
        {
            var repo = new InMemoryTaskRepository();
            var task = new TaskItem("Initial", Guid.NewGuid(), Guid.NewGuid());
            repo.Add(task);

            task = new TaskItem("Updated", task.AssignedToUserId, task.ProjectId) { Id = task.Id };
            repo.Update(task);

            var updated = repo.GetById(task.Id);
            Assert.Equal("Updated", updated?.Description);
        }

        [Fact]
        public void DeleteTask_ShouldRemoveIt()
        {
            var repo = new InMemoryTaskRepository();
            var task = new TaskItem("To Delete", Guid.NewGuid(), Guid.NewGuid());
            repo.Add(task);

            repo.Delete(task.Id);
            var result = repo.GetById(task.Id);

            Assert.Null(result);
        }
    }
}

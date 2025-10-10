using System;
using System.Linq;
using SprintTrack.Core.Entities;
using SprintTrack.Core.Repositories.InMemory;
using Xunit;
using DomainTask = SprintTrack.Core.Entities.Task;

namespace SprintTrack.Tests.Repositories
{
    public class InMemoryTaskRepositoryTests
    {
        [Fact]
        public void CanAddAndRetrieveTask()
        {
            var repo = new InMemoryTaskRepository();
            var task = new DomainTask(Guid.NewGuid(), "Design UI", "desc", Guid.NewGuid(), TaskPriority.High, null);
            repo.Add(task);

            var fetched = repo.GetById(task.Id);
            Assert.Equal("Design UI", fetched.Title);
        }
    }
}

using System;
using SprintTrack.Core.Entities;
using SprintTrack.Core.Services;
using Xunit;

namespace SprintTrack.Tests.Services
{
    public class ServiceTests
    {
        [Fact]
        public void GuidIdGenerator_ShouldReturnUniqueIds()
        {
            var generator = new GuidIdGenerator();
            var id1 = generator.NewId();
            var id2 = generator.NewId();

            Assert.NotEqual(id1, id2);
            Assert.NotEqual(Guid.Empty, id1);
            Assert.NotEqual(Guid.Empty, id2);
        }

        [Fact]
        public void TaskValidator_ShouldThrowIfTitleMissing()
        {
            var task = new Task(Guid.NewGuid(), "", "desc", Guid.NewGuid(), TaskPriority.Medium, null);
            var validator = new TaskValidator();

            var ex = Assert.Throws<ArgumentException>(() => validator.Validate(task));
            Assert.Contains("Task title is required", ex.Message);
        }

        [Fact]
        public void TaskValidator_ShouldPassValidTask()
        {
            var task = new Task(Guid.NewGuid(), "Fix bug", "desc", Guid.NewGuid(), TaskPriority.High, DateTime.Today);
            var validator = new TaskValidator();

            validator.Validate(task); // Should not throw
        }
    }
}

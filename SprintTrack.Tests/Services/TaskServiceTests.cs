using System;
using SprintTrack.Core.Common;
using SprintTrack.Core.Entities;
using SprintTrack.Core.Services;
using Xunit;


namespace SprintTrack.Tests.Services
{
    public class TaskServiceTests
    {
        private readonly TaskService _service;

        public TaskServiceTests()
        {
            var idGen = new GuidIdGenerator();
            var validator = new TaskValidator();
            _service = new TaskService(idGen, validator);
        }

        [Fact]
        public void CreateTask_ShouldReturnSuccess()
        {
            var result = _service.CreateTask(Guid.NewGuid(), "Build UI", "Design dashboard", Guid.NewGuid(), TaskPriority.High, DateTime.Today);
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public void CreateTask_ShouldReturnFailure_WhenTitleMissing()
        {
            var result = _service.CreateTask(Guid.NewGuid(), "", "desc", Guid.NewGuid(), TaskPriority.Low, null);
            Assert.False(result.IsSuccess);
            Assert.Contains("Task title is required", result.Error);
        }
    }
}

using SprintTrack.Core.Entities;
using SprintTrack.Core.Repositories;
using SprintTrack.Infrastructure.Repositories;
using Xunit;

namespace SprintTrack.Tests.Repositories
{
    public class InMemoryProjectRepositoryTests
    {
        [Fact]
        public void AddAndGetProject_ShouldSucceed()
        {
            var repo = new InMemoryProjectRepository();
            var project = new Project("Test Project", DateTime.Today, DateTime.Today.AddDays(7));

            repo.Add(project);
            var fetched = repo.GetById(project.Id);

            Assert.NotNull(fetched);
            Assert.Equal("Test Project", fetched.Title);
        }

        [Fact]
        public void UpdateProject_ShouldModifyData()
        {
            var repo = new InMemoryProjectRepository();
            var project = new Project("Initial", DateTime.Today, DateTime.Today.AddDays(7));
            repo.Add(project);

            project = new Project("Updated", project.StartDate, project.EndDate) { Id = project.Id };
            repo.Update(project);

            var updated = repo.GetById(project.Id);
            Assert.Equal("Updated", updated?.Title);
        }

        [Fact]
        public void DeleteProject_ShouldRemoveIt()
        {
            var repo = new InMemoryProjectRepository();
            var project = new Project("To Delete", DateTime.Today, DateTime.Today.AddDays(7));
            repo.Add(project);

            repo.Delete(project.Id);
            var result = repo.GetById(project.Id);

            Assert.Null(result);
        }
    }
}

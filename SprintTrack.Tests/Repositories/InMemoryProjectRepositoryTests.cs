using System;
using SprintTrack.Core.Entities;
using SprintTrack.Core.Repositories.InMemory;
using Xunit;

namespace SprintTrack.Tests.Repositories
{
    public class InMemoryProjectRepositoryTests
    {
        [Fact]
        public void CanAddAndRetrieveProject()
        {
            var repo = new InMemoryProjectRepository();
            var project = new Project("SprintTrack", "Minimal tracker");
            repo.Add(project);

            var fetched = repo.GetById(project.Id);
            Assert.Equal("SprintTrack", fetched.Name);
        }

        [Fact]
        public void CanUpdateProject()
        {
            var repo = new InMemoryProjectRepository();
            var project = new Project("Old Name", "desc");
            repo.Add(project);

            project = new Project("New Name", "desc") { Id = project.Id };
            repo.Update(project);

            var updated = repo.GetById(project.Id);
            Assert.Equal("New Name", updated.Name);
        }

        [Fact]
        public void CanDeleteProject()
        {
            var repo = new InMemoryProjectRepository();
            var project = new Project("ToDelete", "desc");
            repo.Add(project);

            repo.Delete(project.Id);
            Assert.Null(repo.GetById(project.Id));
        }
    }
}

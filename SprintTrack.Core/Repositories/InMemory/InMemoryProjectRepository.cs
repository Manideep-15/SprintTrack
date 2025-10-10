using System;
using System.Collections.Generic;
using System.Linq;
using SprintTrack.Core.Entities;

namespace SprintTrack.Core.Repositories.InMemory
{
    public class InMemoryProjectRepository : IProjectRepository
    {
        private readonly Dictionary<Guid, Project> _projects = new();

        public void Add(Project project)
        {
            _projects[project.Id] = project;
        }

        public Project GetById(Guid id)
        {
            _projects.TryGetValue(id, out var project);
            return project;
        }

        public IEnumerable<Project> GetAll()
        {
            return _projects.Values;
        }

        public void Update(Project project)
        {
            if (_projects.ContainsKey(project.Id))
                _projects[project.Id] = project;
        }

        public void Delete(Guid id)
        {
            _projects.Remove(id);
        }
    }
}

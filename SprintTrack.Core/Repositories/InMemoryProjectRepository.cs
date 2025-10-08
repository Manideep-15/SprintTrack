using SprintTrack.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SprintTrack.Core.Repositories;

namespace SprintTrack.Core.Repositories
{
    public class InMemoryProjectRepository : IProjectRepository
    {
        private readonly Dictionary<Guid, Project> _projects = new();

        public Project? GetById(Guid id) => _projects.GetValueOrDefault(id);

        public IEnumerable<Project> GetAll() => _projects.Values;

        public void Add(Project project)
        {
            _projects[project.Id] = project;
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

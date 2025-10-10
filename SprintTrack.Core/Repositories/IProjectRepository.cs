using System;
using System.Collections.Generic;
using SprintTrack.Core.Entities;

namespace SprintTrack.Core.Repositories
{
    public interface IProjectRepository
    {
        void Add(Project project);
        Project GetById(Guid id);
        IEnumerable<Project> GetAll();
        void Update(Project project);
        void Delete(Guid id);
    }
}

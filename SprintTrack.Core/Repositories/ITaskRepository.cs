using System;
using System.Collections.Generic;
using DomainTask = SprintTrack.Core.Entities.Task;

namespace SprintTrack.Core.Repositories
{
    public interface ITaskRepository
    {
        void Add(DomainTask task);
        DomainTask GetById(Guid id);
        IEnumerable<DomainTask> GetByProjectId(Guid projectId);
        void Update(DomainTask task);
        void Delete(Guid id);
    }
}

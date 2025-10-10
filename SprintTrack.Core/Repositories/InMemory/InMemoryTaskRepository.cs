using System;
using System.Collections.Generic;
using System.Linq;
using DomainTask = SprintTrack.Core.Entities.Task;

namespace SprintTrack.Core.Repositories.InMemory
{
    public class InMemoryTaskRepository : ITaskRepository
    {
        private readonly Dictionary<Guid, DomainTask> _tasks = new();

        public void Add(DomainTask task)
        {
            _tasks[task.Id] = task;
        }

        public DomainTask GetById(Guid id)
        {
            _tasks.TryGetValue(id, out var task);
            return task;
        }

        public IEnumerable<DomainTask> GetByProjectId(Guid projectId)
        {
            return _tasks.Values.Where(t => t.ProjectId == projectId);
        }

        public void Update(DomainTask task)
        {
            if (_tasks.ContainsKey(task.Id))
                _tasks[task.Id] = task;
        }

        public void Delete(Guid id)
        {
            _tasks.Remove(id);
        }
    }
}

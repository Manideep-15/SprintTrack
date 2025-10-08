using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SprintTrack.Core.Entities;
using SprintTrack.Core.Repositories;

namespace SprintTrack.Core.Repositories
{
    public class InMemoryTaskRepository : ITaskRepository
    {
        private readonly Dictionary<Guid, TaskItem> _tasks = new();

        public TaskItem? GetById(Guid id) => _tasks.GetValueOrDefault(id);

        public IEnumerable<TaskItem> GetAll() => _tasks.Values;

        public void Add(TaskItem task)
        {
            _tasks[task.Id] = task;
        }

        public void Update(TaskItem task)
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

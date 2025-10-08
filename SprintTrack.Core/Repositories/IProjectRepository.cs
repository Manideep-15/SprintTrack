using SprintTrack.Core.Entities;

namespace SprintTrack.Core.Repositories
{
    public interface IProjectRepository
    {
        Project? GetById(Guid id);
        IEnumerable<Project> GetAll();
        void Add(Project project);
        void Update(Project project);
        void Delete(Guid id);
    }
}

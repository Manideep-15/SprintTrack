using SprintTrack.Core.Common;

namespace SprintTrack.Core.Services
{
    public class GuidIdGenerator : IIdGenerator
    {
        public Result<Guid> GenerateId()
        {
            var id = Guid.NewGuid();
            return id == Guid.Empty
                ? Result<Guid>.Failure("Failed to generate ID.")
                : Result<Guid>.Success(id);
        }
    }
}

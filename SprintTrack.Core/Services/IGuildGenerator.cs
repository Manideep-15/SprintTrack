using SprintTrack.Core.Entities;

namespace SprintTrack.Core.Services
{
    public interface IGuildGenerator
    {
        GuildId GenerateId();
    }
}

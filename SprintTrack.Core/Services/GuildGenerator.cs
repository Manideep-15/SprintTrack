using System;
using SprintTrack.Core.Entities;

namespace SprintTrack.Core.Services
{
    public class GuildGenerator : IGuildGenerator
    {
        public GuildId GenerateId()
        {
            return new GuildId(Guid.NewGuid());
        }
    }
}

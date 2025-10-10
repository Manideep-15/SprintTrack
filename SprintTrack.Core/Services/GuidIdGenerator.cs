using System;

namespace SprintTrack.Core.Services
{
    public class GuildIdGenerator : IIdGenerator
    {
        public Guid GenerateId()
        {
            return Guid.NewGuid();
        }
    }
}

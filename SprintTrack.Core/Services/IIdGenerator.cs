using System;

namespace SprintTrack.Core.Services
{
    public interface IIdGenerator
    {
        Guid GenerateId();
    }
}

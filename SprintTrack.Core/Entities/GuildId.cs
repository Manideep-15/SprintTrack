using System;

namespace SprintTrack.Core.Entities
{
    public readonly struct GuildId
    {
        public Guid Value { get; }

        public GuildId(Guid value)
        {
            if (value == Guid.Empty)
                throw new ArgumentException("GuildId cannot be empty.");

            Value = value;
        }

        public override string ToString() => Value.ToString();
    }
}

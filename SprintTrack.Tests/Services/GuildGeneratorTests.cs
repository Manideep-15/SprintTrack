using System;
using SprintTrack.Core.Entities;
using SprintTrack.Core.Services;
using Xunit;

namespace SprintTrack.Tests.Services
{
    public class GuildGeneratorTests
    {
        [Fact]
        public void GenerateId_ShouldReturnValidGuildId()
        {
            var generator = new GuildGenerator();
            var id = generator.GenerateId();

            Assert.NotEqual(Guid.Empty, id.Value);
        }
    }
}

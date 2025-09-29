using SprintTrack.Core.Services;
using Xunit;

namespace SprintTrack.Tests.Services
{
    public class GuidIdGeneratorTests
    {
        [Fact]
        public void GenerateId_ShouldReturnUniqueGuid()
        {
            var generator = new GuidIdGenerator();
            var id1 = generator.GenerateId();
            var id2 = generator.GenerateId();

            Assert.NotEqual(id1, id2);
            Assert.NotEqual(Guid.Empty, id1);
        }
    }
}

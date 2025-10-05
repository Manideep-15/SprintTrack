using SprintTrack.Core.Services;
using Xunit;

namespace SprintTrack.Tests.Services
{
    public class GuidIdGeneratorTests
    {
        [Fact]
        public void GenerateId_ShouldReturnSuccessResult()
        {
            var generator = new GuidIdGenerator();
            var result = generator.GenerateId();

            Assert.True(result.IsSuccess);
            Assert.NotEqual(Guid.Empty, result.Value);
        }

        [Fact]
        public void GenerateId_ShouldReturnUniqueIds()
        {
            var generator = new GuidIdGenerator();
            var result1 = generator.GenerateId();
            var result2 = generator.GenerateId();

            Assert.True(result1.IsSuccess);
            Assert.True(result2.IsSuccess);
            Assert.NotEqual(result1.Value, result2.Value);
        }
    }
}

using FluentAssertions;
using MessagePack;
using Models.MessagePack;
using Xunit;

namespace Models.Tests
{
    public class RoundtripDTOsTests
    {
        [Fact]
        public void RoundtripTestDTO_A()
        {
            TestDTO orig = new TestDTO()
            {
                FamilyName = "Smith",
                GivenName = "Aldwin"
            };
            var buffer = MessagePackSerializer.Serialize<TestDTO>(orig);
            var copy = MessagePackSerializer.Deserialize<TestDTO>(buffer);

            copy.Should().Be(orig);
            copy.Equals(orig).Should().BeTrue();

            copy.GetFullLegalName().Should().Be("Aldwin SMITH");
        }

        [Fact]
        public void RoundtripTestDTO_B()
        {
            TestDTO orig = new TestDTO()
            {
                FamilyName = "Smith",
                GivenName = "Aldwin",
                OtherNames = "Bracus Cayman",
            };
            var buffer = MessagePackSerializer.Serialize<TestDTO>(orig);
            var copy = MessagePackSerializer.Deserialize<TestDTO>(buffer);

            copy.Should().Be(orig);
            copy.Equals(orig).Should().BeTrue();

            copy.GetFullLegalName().Should().Be("Aldwin Bracus Cayman SMITH");
        }
    }
}
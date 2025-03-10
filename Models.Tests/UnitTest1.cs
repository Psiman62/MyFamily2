using MessagePack;
using Models.MessagePack;
using Shouldly;
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

            copy.ShouldBe(orig);
            copy.Equals(orig).ShouldBeTrue();

            copy.GetFullLegalName().ShouldBe("Aldwin SMITH");
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

            copy.ShouldBe(orig);
            copy.Equals(orig).ShouldBeTrue();

            copy.GetFullLegalName().ShouldBe("Aldwin Bracus Cayman SMITH");
        }
    }
}
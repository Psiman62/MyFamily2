using DTOMaker.Models;
using DTOMaker.Models.MessagePack;

namespace Models
{
    [Entity()][EntityTag(1)]
    public interface ITestDTO
    {
        [Member(1)] string FamilyName { get; set; }
        [Member(2)] string GivenName { get; set; }
        [Member(3)] string? OtherNames { get; set; }
    }
}


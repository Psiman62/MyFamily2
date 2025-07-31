using DTOMaker.Models;
using DTOMaker.Runtime;

namespace Models
{
    [Entity()][Id(1)]
    public interface ITestDTO : IEntityBase
    {
        [Member(1)] string FamilyName { get; set; }
        [Member(2)] string GivenName { get; set; }
        [Member(3)] string? OtherNames { get; set; }
    }
}


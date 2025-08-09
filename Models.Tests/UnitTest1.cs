using DTOMaker.Runtime.JsonNewtonSoft;
using Models.JsonNewtonSoft;
using Shouldly;
using Xunit;

namespace Models.Tests
{
    public class RoundtripDTOsTests
    {
        [Fact]
        public void RoundtripTestDTO_A()
        {
            MyTodoList orig = new MyTodoList()
            {
                Item0 = new MyTodoItem() { Id = 1, Description = "Brush teeth", Started = true },
                Item1 = new MyTodoItem() { Id = 2, Description = "Turn off A/C" },
                Item2 = new MyTodoItem() { Id = 3, Description = "Lock door" },
            };
            orig.Freeze();

            string buffer = orig.ToJson<MyTodoList>();
            var copy = buffer.FromJson<MyTodoList>();

            copy.ShouldNotBeNull();
            copy.Freeze();

            copy.ShouldBe(orig);
            copy.Equals(orig).ShouldBeTrue();
        }
    }
}
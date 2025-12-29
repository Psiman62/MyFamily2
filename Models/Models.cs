using DTOMaker.Models;
using DTOMaker.Runtime;
using System.Collections;
using System.Collections.Generic;

namespace Models
{
    //[Entity]
    //[Id(1)]
    //public interface IProfileState : IEntityBase
    //{
    //    [Member(1)] string ProfileName { get; set; }
    //}

    [Entity(2)]
    public interface IMyTodoList : IEntityBase
    {
        [Member(1)] IMyTodoItem? Item0 { get; set; }
        [Member(2)] IMyTodoItem? Item1 { get; set; }
        [Member(3)] IMyTodoItem? Item2 { get; set; }
        [Member(4)] IMyTodoItem? Item3 { get; set; }

        IEnumerable<IMyTodoItem> Items { get; }
    }

    [Entity(3)]
    public interface IMyTodoItem : IEntityBase
    {
        [Member(1)] int Id { get; set; }
        [Member(2)] bool Started { get; set; }
        [Member(3)] bool Completed { get; set; }
        [Member(4)] string Description { get; set; }

        string State { get; }
    }
}


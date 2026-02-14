using DTOMaker.Models;
using DTOMaker.Runtime;
using System;
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
        [Member(1)][Name("item0")] IMyTodoItem? Item0 { get; set; }
        [Member(2)][Name("item1")] IMyTodoItem? Item1 { get; set; }
        [Member(3)][Name("item2")] IMyTodoItem? Item2 { get; set; }
        [Member(4)][Name("item3")] IMyTodoItem? Item3 { get; set; }

        IEnumerable<IMyTodoItem> Items { get; }
    }

    [Entity(3)]
    public interface IMyTodoItem : IEntityBase
    {
        [Member(1)][Name("id")] int Id { get; set; }
        [Member(2)][Name("started")] bool Started { get; set; }
        [Member(3)][Name("completed")] bool Completed { get; set; }
        [Member(4)][Name("description")] string? Description { get; set; }

        string State { get; }
    }

    [Entity(10)]
    public interface IServerFunc1Response : IEntityBase
    {
        [Member(1)] IServerInfo ServerInfo { get; set; }
    }

    [Entity(11)]
    public interface IServerInfo : IEntityBase
    {
        [Member(1)] string FileVersion { get; set; }
        [Member(2, NativeType.Int64, typeof(DateTimeConverter))] DateTime CommitDate { get; set; }
        [Member(3, NativeType.PairOfInt64, typeof(DateTimeOffsetConverter))] DateTimeOffset Timestamp { get; set; }
    }
}


using System;
using System.Collections.Generic;

namespace Models.JsonNewtonSoft
{
    public partial class MyTodoList
    {
        public IEnumerable<IMyTodoItem> Items
        {
            get
            {
                if (Item0 is not null) yield return Item0;
                if (Item1 is not null) yield return Item1;
                if (Item2 is not null) yield return Item2;
                if (Item3 is not null) yield return Item3;
            }
        }

        public void Clear()
        {
                Item0 = null;
                Item1 = null;
                Item2 = null;
                Item3 = null;
        }

        public void Add(MyTodoItem item)
        {
            if (Item0 is null)
            {
                Item0 = item;
                return;
            }
            if (Item1 is null)
            {
                Item1 = item;
                return;
            }
            if (Item2 is null)
            {
                Item2 = item;
                return;
            }
            if (Item3 is null)
            {
                Item3 = item;
                return;
            }
        }
    }
    public partial class MyTodoItem
    {
        public string State => (Started, Completed) switch
        {
            (_, true) => "Completed",
            (true, _) => "Started",
            (_, _) => "Pending",
        };
    }
}
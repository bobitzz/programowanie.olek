using System;
using System.Collections.Generic;

namespace ToDoListClassLibrary.Models;

public partial class List
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public bool IsDone { get; set; }

    public bool IsDelete { get; set; }
}

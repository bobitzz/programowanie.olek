using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToDoClassLibrary.Models;

[Table("todotasks")]
public partial class Todotask
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("content")]
    [StringLength(100)]
    public string Content { get; set; } = null!;

    [Column("isDone")]
    public bool IsDone { get; set; }

    [Column("isDeleted")]
    public bool IsDeleted { get; set; }
}

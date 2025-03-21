using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuizDatabaseClassLibrary.Models;

[Table("questions")]
public partial class Question
{
    [Key]
    [Column("id", TypeName = "int(10)")]
    public int Id { get; set; }

    [Column("text")]
    [StringLength(90)]
    public string Text { get; set; } = null!;

    [InverseProperty("IdQuestionNavigation")]
    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
}

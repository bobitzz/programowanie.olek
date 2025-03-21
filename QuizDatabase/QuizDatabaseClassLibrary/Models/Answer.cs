using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuizDatabaseClassLibrary.Models;

[Table("answers")]
[Index("IdQuestion", Name = "FK_idQuestion")]
public partial class Answer
{
    [Key]
    [Column("id", TypeName = "int(10)")]
    public int Id { get; set; }

    [Column("text")]
    [StringLength(30)]
    public string Text { get; set; } = null!;

    public bool IsCorrect { get; set; }

    [Column("id_question", TypeName = "int(10)")]
    public int IdQuestion { get; set; }

    [ForeignKey("IdQuestion")]
    [InverseProperty("Answers")]
    public virtual Question IdQuestionNavigation { get; set; } = null!;
}

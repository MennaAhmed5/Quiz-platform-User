﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Quiz_platform_User.DAL.Models;

[Index("QuizId", Name = "IX_Questions_QuizId")]
public partial class Question
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string QuestionText { get; set; }

    [Required]
    public string AnswerType { get; set; }

    public int QuizId { get; set; }

    [InverseProperty("Question")]
    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    [ForeignKey("QuizId")]
    [InverseProperty("Questions")]
    public virtual Quize Quiz { get; set; }
}
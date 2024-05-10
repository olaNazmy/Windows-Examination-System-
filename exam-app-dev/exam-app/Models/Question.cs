using System;
using System.Collections.Generic;

namespace exam_app.Models;

public partial class Question
{
    public int QId { get; set; }

    public string QContent { get; set; } = null!;

    public string QType { get; set; } = null!;

    public string ModelAnswer { get; set; } = null!;

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<ExamStdQuestion> ExamStdQuestions { get; set; } = new List<ExamStdQuestion>();

    public virtual ICollection<QuestionChoice> QuestionChoices { get; set; } = new List<QuestionChoice>();

    public virtual ICollection<Exam> Exes { get; set; } = new List<Exam>();
}

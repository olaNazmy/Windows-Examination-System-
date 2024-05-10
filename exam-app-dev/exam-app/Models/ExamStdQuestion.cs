using System;
using System.Collections.Generic;

namespace exam_app.Models;

public partial class ExamStdQuestion
{
    public int ExId { get; set; }

    public int StId { get; set; }

    public int QId { get; set; }

    public string StdAnswer { get; set; } = null!;

    public virtual Exam Ex { get; set; } = null!;

    public virtual Question QIdNavigation { get; set; } = null!;

    public virtual Student St { get; set; } = null!;
}

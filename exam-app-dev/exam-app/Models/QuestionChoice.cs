using System;
using System.Collections.Generic;

namespace exam_app.Models;

public partial class QuestionChoice
{
    public int QId { get; set; }

    public string QChoice { get; set; } = null!;

    public virtual Question QIdNavigation { get; set; } = null!;
}

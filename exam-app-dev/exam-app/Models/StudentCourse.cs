using System;
using System.Collections.Generic;

namespace exam_app.Models;

public partial class StudentCourse
{
    public int StdId { get; set; }

    public int CrsId { get; set; }

    public int? TotalGrade { get; set; }

    public virtual Course Crs { get; set; } = null!;

    public virtual Student Std { get; set; } = null!;
}

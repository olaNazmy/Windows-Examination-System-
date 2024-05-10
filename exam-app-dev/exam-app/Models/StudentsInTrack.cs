using System;
using System.Collections.Generic;

namespace exam_app.Models;

public partial class StudentsInTrack
{
    public int StudentId { get; set; }

    public int TrackId { get; set; }

    public int Durations { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Track Track { get; set; } = null!;
}

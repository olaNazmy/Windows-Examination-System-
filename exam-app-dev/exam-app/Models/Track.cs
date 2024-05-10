using System;
using System.Collections.Generic;

namespace exam_app.Models;

public partial class Track
{
    public int TrId { get; set; }

    public string TrName { get; set; } = null!;

    public virtual ICollection<StudentsInTrack> StudentsInTracks { get; set; } = new List<StudentsInTrack>();

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<Course> Crs { get; set; } = new List<Course>();
}

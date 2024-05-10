using System;
using System.Collections.Generic;

namespace exam_app.Models;

public partial class Branch
{
    public int BranchId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}

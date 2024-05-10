using System;
using System.Collections.Generic;

namespace exam_app.Models;

public partial class Instructor
{
    public int InsId { get; set; }

    public string InsFname { get; set; } = null!;

    public string InsLname { get; set; } = null!;

    public DateOnly? InsBirthDate { get; set; }

    public int? InsAge { get; set; }

    public string? InsPhone { get; set; }

    public string? InsDegree { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<InsCourse> InsCourses { get; set; } = new List<InsCourse>();

    public virtual LoginAccount? User { get; set; }
}

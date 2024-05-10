using System;
using System.Collections.Generic;

namespace exam_app.Models;

public partial class Course
{
    public int CrsId { get; set; }

    public string CrsName { get; set; } = null!;

    public int CrsDuration { get; set; }

    public int? TopicId { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<InsCourse> InsCourses { get; set; } = new List<InsCourse>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual Topic? Topic { get; set; }

    public virtual ICollection<Track> Trs { get; set; } = new List<Track>();
}

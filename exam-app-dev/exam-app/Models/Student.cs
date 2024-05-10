using System;
using System.Collections.Generic;

namespace exam_app.Models;

public partial class Student
{
    public int StId { get; set; }

    public string StFname { get; set; } = null!;

    public string StLname { get; set; } = null!;

    public string StGender { get; set; } = null!;

    public DateOnly StBirthdate { get; set; }

    public int? StAge { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public int? StPhone { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<ExamStdQuestion> ExamStdQuestions { get; set; } = new List<ExamStdQuestion>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<StudentExam> StudentExams { get; set; } = new List<StudentExam>();

    public virtual ICollection<StudentsInTrack> StudentsInTracks { get; set; } = new List<StudentsInTrack>();

    public virtual LoginAccount? User { get; set; }
}

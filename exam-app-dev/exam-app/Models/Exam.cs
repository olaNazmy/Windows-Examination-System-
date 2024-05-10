using System;
using System.Collections.Generic;

namespace exam_app.Models;

    public partial class Exam
    {
        public int ExId { get; set; }

        public DateTime ExDate { get; set; }

        public int ExDuration { get; set; }

        public string? ExamName { get; set; }

        public int? CourseId { get; set; }

        public virtual Course? Course { get; set; }

        public virtual ICollection<ExamStdQuestion> ExamStdQuestions { get; set; } = new List<ExamStdQuestion>();

        public virtual ICollection<StudentExam> StudentExams { get; set; } = new List<StudentExam>();

        public virtual ICollection<Question> QIds { get; set; } = new List<Question>();
    }

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace exam_app.Models;

public partial class ItidbContext : DbContext
{
    public ItidbContext()
    {
    }

    public ItidbContext(DbContextOptions<ItidbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<ExamStdQuestion> ExamStdQuestions { get; set; }

    public virtual DbSet<InsCourse> InsCourses { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<LoginAccount> LoginAccounts { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionChoice> QuestionChoices { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<StudentExam> StudentExams { get; set; }

    public virtual DbSet<StudentsInTrack> StudentsInTracks { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<Track> Tracks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=ITIDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branch");

            entity.Property(e => e.BranchId).HasColumnName("Branch_id");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);

            entity.HasMany(d => d.Tracks).WithMany(p => p.Branches)
                .UsingEntity<Dictionary<string, object>>(
                    "BranchesTrack",
                    r => r.HasOne<Track>().WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_BranchesTracks_Track"),
                    l => l.HasOne<Branch>().WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_BranchesTracks_Branch"),
                    j =>
                    {
                        j.HasKey("BranchId", "TrackId").HasName("PK_Branch'sTracks");
                        j.ToTable("BranchesTracks");
                        j.IndexerProperty<int>("BranchId").HasColumnName("Branch_id");
                        j.IndexerProperty<int>("TrackId").HasColumnName("Track_id");
                    });
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CrsId);

            entity.ToTable("Course");

            entity.Property(e => e.CrsId).HasColumnName("Crs_id");
            entity.Property(e => e.CrsDuration).HasColumnName("Crs_duration");
            entity.Property(e => e.CrsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Crs_name");
            entity.Property(e => e.TopicId).HasColumnName("Topic_id");

            entity.HasOne(d => d.Topic).WithMany(p => p.Courses)
                .HasForeignKey(d => d.TopicId)
                .HasConstraintName("FK_Course_Topic");

            entity.HasMany(d => d.Trs).WithMany(p => p.Crs)
                .UsingEntity<Dictionary<string, object>>(
                    "CrsTrack",
                    r => r.HasOne<Track>().WithMany()
                        .HasForeignKey("TrId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Crs_Track_Track"),
                    l => l.HasOne<Course>().WithMany()
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Crs_Track_Course"),
                    j =>
                    {
                        j.HasKey("CrsId", "TrId");
                        j.ToTable("Crs_Track");
                        j.IndexerProperty<int>("CrsId").HasColumnName("Crs_id");
                        j.IndexerProperty<int>("TrId").HasColumnName("Tr_id");
                    });
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.ExId);

            entity.ToTable("Exam");

            entity.Property(e => e.ExId).HasColumnName("Ex_id");
            entity.Property(e => e.CourseId).HasColumnName("Course_id");
            entity.Property(e => e.ExDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Ex_date");
            entity.Property(e => e.ExDuration).HasColumnName("Ex_duration");
            entity.Property(e => e.ExamName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Exam_Name");

            entity.HasOne(d => d.Course).WithMany(p => p.Exams)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Exam_Course");

            entity.HasMany(d => d.QIds).WithMany(p => p.Exes)
                .UsingEntity<Dictionary<string, object>>(
                    "ExamQuestion",
                    r => r.HasOne<Question>().WithMany()
                        .HasForeignKey("QId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Question_Question"),
                    l => l.HasOne<Exam>().WithMany()
                        .HasForeignKey("ExId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Question_Exam"),
                    j =>
                    {
                        j.HasKey("ExId", "QId");
                        j.ToTable("Exam_Question");
                        j.IndexerProperty<int>("ExId").HasColumnName("Ex_id");
                        j.IndexerProperty<int>("QId").HasColumnName("Q_id");
                    });
        });

        modelBuilder.Entity<ExamStdQuestion>(entity =>
        {
            entity.HasKey(e => new { e.ExId, e.StId, e.QId });

            entity.ToTable("Exam_Std_Question");

            entity.Property(e => e.ExId).HasColumnName("Ex_id");
            entity.Property(e => e.StId).HasColumnName("St_id");
            entity.Property(e => e.QId).HasColumnName("Q_id");
            entity.Property(e => e.StdAnswer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Std_answer");

            entity.HasOne(d => d.Ex).WithMany(p => p.ExamStdQuestions)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Exam_Std_Question_Exam");

            entity.HasOne(d => d.QIdNavigation).WithMany(p => p.ExamStdQuestions)
                .HasForeignKey(d => d.QId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Exam_Std_Question_Question");

            entity.HasOne(d => d.St).WithMany(p => p.ExamStdQuestions)
                .HasForeignKey(d => d.StId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Exam_Std_Question_Student");
        });

        modelBuilder.Entity<InsCourse>(entity =>
        {
            entity.HasKey(e => new { e.InsId, e.CrsId });

            entity.ToTable("Ins_Courses");

            entity.Property(e => e.InsId).HasColumnName("Ins_id");
            entity.Property(e => e.CrsId).HasColumnName("Crs_id");
            entity.Property(e => e.Evaluation)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Crs).WithMany(p => p.InsCourses)
                .HasForeignKey(d => d.CrsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ins_Courses_Course");

            entity.HasOne(d => d.Ins).WithMany(p => p.InsCourses)
                .HasForeignKey(d => d.InsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ins_Courses_Instructor");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InsId).HasName("PK_Instructors");

            entity.ToTable("Instructor");

            entity.Property(e => e.InsId).HasColumnName("Ins_Id");
            entity.Property(e => e.InsAge)
                .HasComputedColumnSql("(datediff(year,[Ins_BirthDate],getdate()))", false)
                .HasColumnName("Ins_Age");
            entity.Property(e => e.InsBirthDate).HasColumnName("Ins_BirthDate");
            entity.Property(e => e.InsDegree)
                .HasMaxLength(20)
                .HasColumnName("Ins_Degree");
            entity.Property(e => e.InsFname)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("Ins_Fname");
            entity.Property(e => e.InsLname)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("Ins_Lname");
            entity.Property(e => e.InsPhone)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("Ins_Phone");
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.User).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Instructor_Login_Accounts");
        });

        modelBuilder.Entity<LoginAccount>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("Login_Accounts");

            entity.Property(e => e.UserId).HasColumnName("User_id");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QId).HasName("PK_Table_1");

            entity.ToTable("Question");

            entity.Property(e => e.QId).HasColumnName("Q_id");
            entity.Property(e => e.CourseId).HasColumnName("Course_id");
            entity.Property(e => e.ModelAnswer)
                .IsUnicode(false)
                .HasColumnName("Model_answer");
            entity.Property(e => e.QContent)
                .IsUnicode(false)
                .HasColumnName("Q_content");
            entity.Property(e => e.QType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Q_type");

            entity.HasOne(d => d.Course).WithMany(p => p.Questions)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Question_Course");
        });

        modelBuilder.Entity<QuestionChoice>(entity =>
        {
            entity.HasKey(e => new { e.QId, e.QChoice }).HasName("PK_Q_choices");

            entity.ToTable("Question_choices");

            entity.Property(e => e.QId).HasColumnName("Q_id");
            entity.Property(e => e.QChoice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Q_choice");

            entity.HasOne(d => d.QIdNavigation).WithMany(p => p.QuestionChoices)
                .HasForeignKey(d => d.QId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Question_choices_Question");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StId);

            entity.ToTable("Student");

            entity.Property(e => e.StId).HasColumnName("St_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StAge)
                .HasComputedColumnSql("(datepart(year,getdate())-datepart(year,[St_birthdate]))", false)
                .HasColumnName("St_age");
            entity.Property(e => e.StBirthdate).HasColumnName("St_birthdate");
            entity.Property(e => e.StFname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("St_fname");
            entity.Property(e => e.StGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("St_gender");
            entity.Property(e => e.StLname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("St_lname");
            entity.Property(e => e.StPhone).HasColumnName("St_phone");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.User).WithMany(p => p.Students)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Student_Login_Accounts");
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasKey(e => new { e.StdId, e.CrsId });

            entity.ToTable("Student_Courses");

            entity.Property(e => e.StdId).HasColumnName("Std_id");
            entity.Property(e => e.CrsId).HasColumnName("Crs_id");
            entity.Property(e => e.TotalGrade).HasColumnName("Total_Grade");

            entity.HasOne(d => d.Crs).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.CrsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Courses_Course");

            entity.HasOne(d => d.Std).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.StdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Courses_Student");
        });

        modelBuilder.Entity<StudentExam>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.ExamId }).HasName("PK_Student_Exames");

            entity.ToTable("Student_Exams");

            entity.Property(e => e.StudentId).HasColumnName("Student_id");
            entity.Property(e => e.ExamId).HasColumnName("Exam_id");

            entity.HasOne(d => d.Exam).WithMany(p => p.StudentExams)
                .HasForeignKey(d => d.ExamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Exames_Exam");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentExams)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Exames_Student");
        });

        modelBuilder.Entity<StudentsInTrack>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.TrackId });

            entity.ToTable("Students_InTracks");

            entity.Property(e => e.StudentId).HasColumnName("Student_Id");
            entity.Property(e => e.TrackId).HasColumnName("Track_id");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentsInTracks)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_InTracks_Student");

            entity.HasOne(d => d.Track).WithMany(p => p.StudentsInTracks)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_InTracks_Track");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.ToTable("Topic");

            entity.Property(e => e.TopicId).HasColumnName("Topic_id");
            entity.Property(e => e.TopicName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Topic_name");
        });

        modelBuilder.Entity<Track>(entity =>
        {
            entity.HasKey(e => e.TrId);

            entity.ToTable("Track");

            entity.Property(e => e.TrId).HasColumnName("Tr_id");
            entity.Property(e => e.TrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tr_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

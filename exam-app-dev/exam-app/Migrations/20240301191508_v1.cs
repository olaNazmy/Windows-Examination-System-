using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exam_app.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Branch",
            //    columns: table => new
            //    {
            //        Branch_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Branch", x => x.Branch_id);
            //    });

            migrationBuilder.CreateTable(
                name: "Login_Accounts",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Role = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login_Accounts", x => x.User_id);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Topic_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Topic_id);
                });

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    Tr_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tr_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.Tr_id);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Ins_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ins_Lname = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: false),
                    Ins_Fname = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: false),
                    Ins_BirthDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Ins_Age = table.Column<int>(type: "int", nullable: true, computedColumnSql: "(datediff(year,[Ins_BirthDate],getdate()))", stored: false),
                    Ins_Phone = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    Ins_Degree = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    User_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Ins_Id);
                    table.ForeignKey(
                        name: "FK_Instructor_Login_Accounts",
                        column: x => x.User_id,
                        principalTable: "Login_Accounts",
                        principalColumn: "User_id");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    St_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    St_fname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    St_lname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    St_gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    St_birthdate = table.Column<DateOnly>(type: "date", nullable: false),
                    St_age = table.Column<int>(type: "int", nullable: true, computedColumnSql: "(datepart(year,getdate())-datepart(year,[St_birthdate]))", stored: false),
                    City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Street = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    St_phone = table.Column<int>(type: "int", nullable: true),
                    User_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.St_id);
                    table.ForeignKey(
                        name: "FK_Student_Login_Accounts",
                        column: x => x.User_id,
                        principalTable: "Login_Accounts",
                        principalColumn: "User_id");
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Crs_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crs_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Crs_duration = table.Column<int>(type: "int", nullable: false),
                    Topic_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Crs_id);
                    table.ForeignKey(
                        name: "FK_Course_Topic",
                        column: x => x.Topic_id,
                        principalTable: "Topic",
                        principalColumn: "Topic_id");
                });

            migrationBuilder.CreateTable(
                name: "BranchesTracks",
                columns: table => new
                {
                    Branch_id = table.Column<int>(type: "int", nullable: false),
                    Track_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch'sTracks", x => new { x.Branch_id, x.Track_id });
                    table.ForeignKey(
                        name: "FK_BranchesTracks_Branch",
                        column: x => x.Branch_id,
                        principalTable: "Branch",
                        principalColumn: "Branch_id");
                    table.ForeignKey(
                        name: "FK_BranchesTracks_Track",
                        column: x => x.Track_id,
                        principalTable: "Track",
                        principalColumn: "Tr_id");
                });

            migrationBuilder.CreateTable(
                name: "Students_InTracks",
                columns: table => new
                {
                    Student_Id = table.Column<int>(type: "int", nullable: false),
                    Track_id = table.Column<int>(type: "int", nullable: false),
                    Durations = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students_InTracks", x => new { x.Student_Id, x.Track_id });
                    table.ForeignKey(
                        name: "FK_Students_InTracks_Student",
                        column: x => x.Student_Id,
                        principalTable: "Student",
                        principalColumn: "St_id");
                    table.ForeignKey(
                        name: "FK_Students_InTracks_Track",
                        column: x => x.Track_id,
                        principalTable: "Track",
                        principalColumn: "Tr_id");
                });

            migrationBuilder.CreateTable(
                name: "Crs_Track",
                columns: table => new
                {
                    Crs_id = table.Column<int>(type: "int", nullable: false),
                    Tr_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crs_Track", x => new { x.Crs_id, x.Tr_id });
                    table.ForeignKey(
                        name: "FK_Crs_Track_Course",
                        column: x => x.Crs_id,
                        principalTable: "Course",
                        principalColumn: "Crs_id");
                    table.ForeignKey(
                        name: "FK_Crs_Track_Track",
                        column: x => x.Tr_id,
                        principalTable: "Track",
                        principalColumn: "Tr_id");
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Ex_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ex_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Ex_duration = table.Column<int>(type: "int", nullable: false),
                    Exam_Name = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Course_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Ex_id);
                    table.ForeignKey(
                        name: "FK_Exam_Course",
                        column: x => x.Course_id,
                        principalTable: "Course",
                        principalColumn: "Crs_id");
                });

            migrationBuilder.CreateTable(
                name: "Ins_Courses",
                columns: table => new
                {
                    Ins_id = table.Column<int>(type: "int", nullable: false),
                    Crs_id = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ins_Courses", x => new { x.Ins_id, x.Crs_id });
                    table.ForeignKey(
                        name: "FK_Ins_Courses_Course",
                        column: x => x.Crs_id,
                        principalTable: "Course",
                        principalColumn: "Crs_id");
                    table.ForeignKey(
                        name: "FK_Ins_Courses_Instructor",
                        column: x => x.Ins_id,
                        principalTable: "Instructor",
                        principalColumn: "Ins_Id");
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Q_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Q_content = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Q_type = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Model_answer = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Course_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_1", x => x.Q_id);
                    table.ForeignKey(
                        name: "FK_Question_Course",
                        column: x => x.Course_id,
                        principalTable: "Course",
                        principalColumn: "Crs_id");
                });

            migrationBuilder.CreateTable(
                name: "Student_Courses",
                columns: table => new
                {
                    Std_id = table.Column<int>(type: "int", nullable: false),
                    Crs_id = table.Column<int>(type: "int", nullable: false),
                    Total_Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Courses", x => new { x.Std_id, x.Crs_id });
                    table.ForeignKey(
                        name: "FK_Student_Courses_Course",
                        column: x => x.Crs_id,
                        principalTable: "Course",
                        principalColumn: "Crs_id");
                    table.ForeignKey(
                        name: "FK_Student_Courses_Student",
                        column: x => x.Std_id,
                        principalTable: "Student",
                        principalColumn: "St_id");
                });

            migrationBuilder.CreateTable(
                name: "Student_Exams",
                columns: table => new
                {
                    Student_id = table.Column<int>(type: "int", nullable: false),
                    Exam_id = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Exames", x => new { x.Student_id, x.Exam_id });
                    table.ForeignKey(
                        name: "FK_Student_Exames_Exam",
                        column: x => x.Exam_id,
                        principalTable: "Exam",
                        principalColumn: "Ex_id");
                    table.ForeignKey(
                        name: "FK_Student_Exames_Student",
                        column: x => x.Student_id,
                        principalTable: "Student",
                        principalColumn: "St_id");
                });

            migrationBuilder.CreateTable(
                name: "Exam_Question",
                columns: table => new
                {
                    Ex_id = table.Column<int>(type: "int", nullable: false),
                    Q_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam_Question", x => new { x.Ex_id, x.Q_id });
                    table.ForeignKey(
                        name: "FK_Exam_Question_Exam",
                        column: x => x.Ex_id,
                        principalTable: "Exam",
                        principalColumn: "Ex_id");
                    table.ForeignKey(
                        name: "FK_Exam_Question_Question",
                        column: x => x.Q_id,
                        principalTable: "Question",
                        principalColumn: "Q_id");
                });

            migrationBuilder.CreateTable(
                name: "Exam_Std_Question",
                columns: table => new
                {
                    Ex_id = table.Column<int>(type: "int", nullable: false),
                    St_id = table.Column<int>(type: "int", nullable: false),
                    Q_id = table.Column<int>(type: "int", nullable: false),
                    Std_answer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam_Std_Question", x => new { x.Ex_id, x.St_id, x.Q_id });
                    table.ForeignKey(
                        name: "FK_Exam_Std_Question_Exam",
                        column: x => x.Ex_id,
                        principalTable: "Exam",
                        principalColumn: "Ex_id");
                    table.ForeignKey(
                        name: "FK_Exam_Std_Question_Question",
                        column: x => x.Q_id,
                        principalTable: "Question",
                        principalColumn: "Q_id");
                    table.ForeignKey(
                        name: "FK_Exam_Std_Question_Student",
                        column: x => x.St_id,
                        principalTable: "Student",
                        principalColumn: "St_id");
                });

            migrationBuilder.CreateTable(
                name: "Question_choices",
                columns: table => new
                {
                    Q_id = table.Column<int>(type: "int", nullable: false),
                    Q_choice = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Q_choices", x => new { x.Q_id, x.Q_choice });
                    table.ForeignKey(
                        name: "FK_Question_choices_Question",
                        column: x => x.Q_id,
                        principalTable: "Question",
                        principalColumn: "Q_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchesTracks_Track_id",
                table: "BranchesTracks",
                column: "Track_id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Topic_id",
                table: "Course",
                column: "Topic_id");

            migrationBuilder.CreateIndex(
                name: "IX_Crs_Track_Tr_id",
                table: "Crs_Track",
                column: "Tr_id");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Course_id",
                table: "Exam",
                column: "Course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Question_Q_id",
                table: "Exam_Question",
                column: "Q_id");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Std_Question_Q_id",
                table: "Exam_Std_Question",
                column: "Q_id");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Std_Question_St_id",
                table: "Exam_Std_Question",
                column: "St_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ins_Courses_Crs_id",
                table: "Ins_Courses",
                column: "Crs_id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_User_id",
                table: "Instructor",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Question_Course_id",
                table: "Question",
                column: "Course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_User_id",
                table: "Student",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Courses_Crs_id",
                table: "Student_Courses",
                column: "Crs_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Exams_Exam_id",
                table: "Student_Exams",
                column: "Exam_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_InTracks_Track_id",
                table: "Students_InTracks",
                column: "Track_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchesTracks");

            migrationBuilder.DropTable(
                name: "Crs_Track");

            migrationBuilder.DropTable(
                name: "Exam_Question");

            migrationBuilder.DropTable(
                name: "Exam_Std_Question");

            migrationBuilder.DropTable(
                name: "Ins_Courses");

            migrationBuilder.DropTable(
                name: "Question_choices");

            migrationBuilder.DropTable(
                name: "Student_Courses");

            migrationBuilder.DropTable(
                name: "Student_Exams");

            migrationBuilder.DropTable(
                name: "Students_InTracks");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Login_Accounts");

            migrationBuilder.DropTable(
                name: "Topic");
        }
    }
}

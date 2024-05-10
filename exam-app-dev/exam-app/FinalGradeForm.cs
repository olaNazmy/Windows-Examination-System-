using exam_app.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exam_app
{
	public partial class FinalGradeForm : Form
	{
		int stdId;
		int examId;
		ItidbContext itiContext;
		public FinalGradeForm(int stId, int exId)
		{
			InitializeComponent();
			stdId = stId;
			examId = exId;
			itiContext = new ItidbContext();
		}

		private void FinalGradeForm_Load(object sender, EventArgs e)
		{
			//used SP :
			//
			//create PROCEDURE CorrectAndCalculateFinalGrade
			//@StudentID INT,
			//@ExamID INT,
			//@FinalGrade INT OUTPUT
			//AS
			//BEGIN

			//DECLARE @TotalCorrectAnswers INT;

			//--Calculate the total number of correct answers

			//SELECT @TotalCorrectAnswers = COUNT(*)

			//FROM Exam_Std_Question AS ESQ

			//INNER JOIN Question AS q ON ESQ.Q_id = q.Q_id

			//WHERE ESQ.St_id = @StudentID AND esq.Ex_id = @ExamID AND ESQ.Std_answer = q.Model_answer;

			//SET @FinalGrade = @TotalCorrectAnswers * 10;
			//END
						
			
			// correct the exam with using stored proc

			var finalGrade = new SqlParameter("@FinalGrade", SqlDbType.Int);
			finalGrade.Direction = ParameterDirection.Output;

			itiContext.Database.ExecuteSqlRaw("EXEC CorrectAndCalculateFinalGrade @StudentID,@ExamID,@FinalGrade OUTPUT",
				new SqlParameter("@StudentID", stdId),
				new SqlParameter("@ExamID", examId),
				finalGrade
				);

			label_grade.Text = finalGrade.Value.ToString();

			///store the result in db 

			if (finalGrade != null)
			{
				if (itiContext.StudentExams.FirstOrDefault(e => e.ExamId == examId && e.StudentId == stdId) == null)
				{
					var stExam = new StudentExam() { ExamId = examId, StudentId = stdId, Grade = (int)finalGrade.Value };
					itiContext.StudentExams.Add(stExam);
					itiContext.SaveChanges();
				}
				else
				{
					MessageBox.Show("You Answered This Exam Before");
				}

			}
			else
			{
				MessageBox.Show("error saving your result");
			}


		}

		private void btn_continue_Click(object sender, EventArgs e)
		{
			var studentMain = new StudentMainForm(stdId);
			Hide();
			studentMain.ShowDialog();
			Close();
		}
	}
}

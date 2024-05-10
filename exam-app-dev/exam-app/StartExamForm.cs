using exam_app.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exam_app
{
    public partial class StartExamForm : Form
    {
        // development part
        private int std_id;
        private int exam_id; 
        ItidbContext appContext = new ItidbContext();
        List<Question> examQuestionList; // questions of exam
        List<List<String>> questionChoices = new List<List<string>>();
        string[] stdAns = new string[10];
        int exam_duration;
        int sec = 0;

        // design part
        private Panel questionPanel;                                                // the panel that hold question with its answers
        private List<Control> questionViews = new List<Control>();             // list to hold all created questionPanel
        private int currentQuestionPanelIndex = 0;


        public StartExamForm(int stdId, int examId)
        {
            InitializeComponent();
            std_id = stdId;
            exam_id = examId;
        }

        void getExamDuration()
        {
            exam_duration =  appContext.Exams.Where(e => e.ExId == exam_id).FirstOrDefault().ExDuration;
        }
        void getExamQuestions(int exam_id)
        {

            examQuestionList = appContext.Exams
           .Where(exam => exam.ExId == exam_id)
           .SelectMany(exam => exam.QIds)
           .ToList();



        }

        void getQuestionsChoices()
        {

            foreach (var question in examQuestionList)
            {
                // Retrieve choices for the current question
                List<string> choicesForQuestion = appContext.QuestionChoices
                    .Where(choice => choice.QId == question.QId)
                    .Select(choice => choice.QChoice)
                    .ToList();

                // Add choices to the questionChoices list
                if (choicesForQuestion.Count == 0)
                    questionChoices.Add(new List<string> { "True", "False" });
                else
                    questionChoices.Add(choicesForQuestion);
            }
        }

        private void StartExamForm_Load(object sender, EventArgs e)
        {
            getExamQuestions(exam_id);
            getQuestionsChoices();

            renderQuestion();
            ShowQuestion(0);
            getExamDuration();

            
            lbl_examDuration.Text = exam_duration.ToString();

            timer1.Start();
        }


        private void renderQuestion()
        {

            //questionPanel.Visible = false;

            for (int i = 0; i < examQuestionList.Count; i++)
            {
                questionPanel = new Panel();
                questionPanel.Dock = DockStyle.Top;
                questionPanel.Height = 500;
                questionPanel.BackColor = SystemColors.ControlLightLight;
                questionPanel.Name = "panel_q" + (i + 1);
                questionPanel.Visible = false;

                // the question label
                var questionLabel = new Label
                {
                    //Dock = DockStyle.Top,
                    Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(20, 30),
                    Name = "question" + (i + 1).ToString(),
                    Size = new Size(1345, 160),
                    TabIndex = 2,
                    Text = "Q" + (i + 1).ToString() + ") " + examQuestionList[i].QContent,
                    TextAlign = ContentAlignment.TopLeft,
                };

                //group that hold questions choices
                var groupBox = new GroupBox()
                {
                    Name = "groupBox" + i.ToString(),
                    Text = "Choices",
                    TabStop = false,
                    Size = new Size(1100, 290),
                    TabIndex = 3,
                    Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(20, 180),

                };

                var choice1 = new RadioButton
                {
                    AutoSize = true,
                    Font = new Font("Tahoma", 14F),
                    Location = new Point(36, 80),
                    Name = "rbtn_choice1" + (i + 1).ToString(),
                    Size = new Size(245, 38),
                    TabIndex = 4,
                    TabStop = true,
                    Text = questionChoices[i][0],
                    UseVisualStyleBackColor = true,
                };
                choice1.CheckedChanged += onRaioBtnClick;

                var choice2 = new RadioButton
                {
                    AutoSize = true,
                    Font = new Font("Tahoma", 14F),
                    Location = new Point(36, 120),
                    Name = "rbtn_choice2" + (i + 1).ToString(),
                    Size = new Size(245, 38),
                    TabIndex = 5,
                    TabStop = true,
                    Text = questionChoices[i][1],
                    UseVisualStyleBackColor = true,
                };
                choice2.CheckedChanged += onRaioBtnClick;
                groupBox.Controls.Add(choice1);
                groupBox.Controls.Add(choice2);
                if (examQuestionList[i].QType.ToLower() == "choose")
                {
                    var choice3 = new RadioButton
                    {
                        AutoSize = true,
                        Font = new Font("Tahoma", 14F),
                        Location = new Point(36, 155),
                        Name = "rbtn_choice3" + (i + 1).ToString(),
                        Size = new Size(245, 38),
                        TabIndex = 6,
                        TabStop = true,
                        Text = questionChoices[i][2],
                        UseVisualStyleBackColor = true,
                    };
                    choice3.CheckedChanged += onRaioBtnClick;
                    var choice4 = new RadioButton
                    {
                        AutoSize = true,
                        Font = new Font("Tahoma", 14F),
                        Location = new Point(36, 190),
                        Name = "rbtn_choice3" + (i + 1).ToString(),
                        Size = new Size(245, 38),
                        TabIndex = 6,
                        TabStop = true,
                        Text = questionChoices[i][3],
                        UseVisualStyleBackColor = true,
                    };
                    choice4.CheckedChanged += onRaioBtnClick;

                    groupBox.Controls.Add(choice3);
                    groupBox.Controls.Add(choice4);
                }


                questionPanel.Controls.Add(questionLabel);
                Controls.Add(questionPanel);
                questionPanel.Controls.Add(groupBox);
                questionViews.Add(questionPanel);

            }

            //ShowQuestion(currentQuestionPanelIndex);
        }

        private void ShowQuestion(int index)
        {
            // Hide all questionPanels
            foreach (Control questionPanel in questionViews)
                questionPanel.Visible = false;

            // Show the questionPanel at the specified index
            questionViews[index].Visible = true;

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (currentQuestionPanelIndex > 0)
            {
                currentQuestionPanelIndex--;
                ShowQuestion(currentQuestionPanelIndex);
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentQuestionPanelIndex < questionViews.Count - 1)
            {
                currentQuestionPanelIndex++;
                ShowQuestion(currentQuestionPanelIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isStdCompleteAllQ())
            {
                DialogResult dialog = MessageBox.Show("your answers will be submitted are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    submitAnswers();
               
                }

            }
            else
            {
                MessageBox.Show("complete your questions at first", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void onRaioBtnClick(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {

                stdAns[currentQuestionPanelIndex] = radioButton.Text;
            }
        }

        bool isStdCompleteAllQ()
        {
            for (int i = 0; i < stdAns.Length; i++)
            {
                if (stdAns[i] == null)
                    return false;
            }
            return true;
        }


        void submitAnswers()
        {
          
            for (int i = 0; i < examQuestionList.Count; i++)
            {
               
                appContext.ExamStdQuestions.Add(new ExamStdQuestion()
                {
                    ExId = exam_id,
                    StId = std_id,
                    QId = examQuestionList[i].QId,
                    StdAnswer = stdAns[i]== null ? "no answer": stdAns[i],
                });

            }
            appContext.SaveChanges();
            MessageBox.Show("your answers are submitted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer1.Stop();
           
            Hide();
            FinalGradeForm form = new FinalGradeForm(std_id, exam_id);
            form.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sec--;
            if (sec == -1)
            {
                exam_duration--;
                sec = 59;
            }


            if (exam_duration == -1)
            {
                timer1.Stop();
                submitAnswers();
            }
            lbl_examDuration.Text = exam_duration.ToString() + ":" + sec.ToString();
        }
    }
}

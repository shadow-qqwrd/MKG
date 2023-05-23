using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace MKG
{
    public partial class TestForm : Form
    {
        int h, w;
        int QuestionNumber = 0;
        float mark = 0;
        Test test = new Test();
        int seconds = 0;

        public TestForm()
        {
            this.DoubleBuffered = true;
            
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void theoryButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void thema_Click(object sender, EventArgs e)
        {
            QuestionLabel.Visible = false;
            ReadyButton.Visible = true;
            XmlParser xmlParser = new XmlParser();
            test = xmlParser.GetTestByThemaName(((Button)sender).Text);
            test.questions.Shuffle();
            EvaluationCriteriaRTB.Visible = false;
            NextQuestionButton.Text = "Следующий вопрос";
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            QuestionLabel.Visible = true;
            NextQuestionButton.Visible = true;
            EvaluationCriteriaRTB.Visible = false;
            QuestionNumber = 0;
            NextQuestionMethod();
            mark = 0;
            ReadyButton.Visible = false;
            LeaveFromTest.Visible = true;
            thema1.Enabled = false;
            thema2.Enabled = false;
            thema3.Enabled = false;
            theoryButton.Enabled = false;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            EvaluationCriteriaRTB.LoadFile("criteria.rtf");
            h = AnswersPanel.Height / 2 - QuestionLabel.Height / 2 - 250;
            w = AnswersPanel.Width / 2 - QuestionLabel.Width / 2 - 300;
            SetRoundedShape(thema1, 20);
            SetRoundedShape(thema2, 20);
            SetRoundedShape(thema3, 20);
            SetRoundedShape(theoryButton, 20);
            SetRoundedShape(NextQuestionButton, 20);
            SetRoundedShape(ReadyButton, 20);
        }

        private void NextQuestion_Click(object sender, EventArgs e)
        {
            CheckTrueOrNot();
            if (NextQuestionButton.Text == "Закончить тестирование")
            {
                thema1.Enabled = true;
                thema2.Enabled = true;
                thema3.Enabled = true;
                theoryButton.Enabled = true;
                SecondsLeftLabel.Visible = false;
                LeaveFromTest.Visible = false;
                QuestionLabel.Text = $"Количество правильных ответов - {mark} из 10 \n"+((mark > 8)?"Оценка: 5":(mark > 6)?"Оценка: 4":(mark > 5)?"Оценка: 3":"Оценка: 2");
                NextQuestionButton.Visible = false;
            }
            Clear();
            NextQuestionMethod();
        }
        public void CheckTrueOrNot()
        {
            int countTrue = 0;
            int questionNow = QuestionNumber - 1;
            int count = test.questions[questionNow].variants.Count;
            if (count == 1)
            {
                int i = 0;
                foreach (Control control in AnswersPanel.Controls)
                {
                    if (control.Tag?.ToString() == "variant")
                    {
                        if (test.questions[questionNow].variants[i].isTrue == true)
                            if (((TextBox)control).Text == test.questions[questionNow].variants[0].text)
                                mark++;
                        i++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (test.questions[questionNow].variants[i].isTrue)
                    {
                        countTrue++;
                    }
                }

                if (countTrue == 1)
                {
                    int i = 0;
                    foreach (Control control in AnswersPanel.Controls)
                    {
                        if (control.Tag?.ToString() == "variant")
                        {
                            if (test.questions[questionNow].variants[i].isTrue == true)
                                if (((RadioButton)control).Checked == test.questions[questionNow].variants[i].isTrue)
                                    mark++;
                            i++;
                        }
                    }
                }
                else
                {
                    int countTrueSelected = 0;
                    int i = 0;
                    foreach (Control control in AnswersPanel.Controls)
                    {
                        if (control.Tag?.ToString() == "variant")
                        {
                            if (test.questions[questionNow].variants[i].isTrue)
                            {
                                if (((CheckBox)control).Checked == (test.questions[questionNow].variants[i].isTrue))
                                    countTrueSelected++;
                            }
                            i++;
                        }
                    }
                    mark += (float)countTrueSelected / countTrue;
                }
            }
        }

        public void Clear()
        {
            List<Control> removeControls = new List<Control>();
            foreach (Control control in AnswersPanel.Controls)
            {
                if (control.Tag?.ToString() == "variant")
                    removeControls.Add(control);
            }
            
            foreach(Control control in removeControls)
                AnswersPanel.Controls.Remove(control);
        }

        public void NextQuestionMethod()
        {
            if (QuestionNumber == 10)
            {
                NextQuestionButton.Text = "Закончить тестирование";
            }
            else
            {
                int countTrue = 0;
                QuestionLabel.Text = (QuestionNumber+1)+ "/10 " + test.questions[QuestionNumber].text.ToString();
                int count = test.questions[QuestionNumber].variants.Count;
                if (count == 1)
                {
                    TextBox newTextBox = new TextBox();
                    newTextBox.Tag = "variant";
                    newTextBox.Font = new Font("Consolas", 16);
                    newTextBox.Size = new Size(900, 40);

                    AnswersPanel.Controls.Add(newTextBox);
                    newTextBox.Location = new Point(QuestionLabel.Location.X, 30 + QuestionLabel.Location.Y + 100);

                    SecondsLeftLabel.Visible = true;
                    seconds = 91;
                    timer.Start();
                    if (QuestionNumber == 9)
                    {
                        NextQuestionButton.Text = "Закончить тестирование";
                    }
                }
                else
                {
                    QuestionLabel.Text = (QuestionNumber + 1) + "/10 " + test.questions[QuestionNumber].text.ToString();
                    SecondsLeftLabel.Visible = true;
                    for (int i = 0; i < count; i++)
                    {
                        if (test.questions[QuestionNumber].variants[i].isTrue)
                        {
                            countTrue++;
                        }
                    }

                    if (countTrue == 1)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            RadioButton newButton = new RadioButton();
                            newButton.Tag = "variant";
                            newButton.BackColor = Color.Transparent;
                            newButton.Text = test.questions[QuestionNumber].variants[i].text;
                            newButton.Font = new Font("Consolas", 16);
                            AnswersPanel.Controls.Add(newButton);
                            newButton.AutoSize = true;
                            newButton.Location = new Point(QuestionLabel.Location.X+30, 30 + QuestionLabel.Location.Y+50 * (i + 1));
                            SecondsLeftLabel.Visible = true;
                            seconds = 31;
                            timer.Start();
                            if (QuestionNumber == 9)
                            {
                                NextQuestionButton.Text = "Закончить тестирование";
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            CheckBox newButton = new CheckBox();
                            newButton.Tag = "variant";
                            newButton.BackColor = Color.Transparent;
                            newButton.Text = test.questions[QuestionNumber].variants[i].text;
                            newButton.Font = new Font("Consolas", 16);
                            AnswersPanel.Controls.Add(newButton);
                            AnswersPanel.Controls.Add(SecondsLeftLabel);
                            newButton.AutoSize = true;
                            newButton.Location = new Point(QuestionLabel.Location.X+30, 30+QuestionLabel.Location.Y + 50 * (i + 1));
                            SecondsLeftLabel.Visible = true;
                            seconds = 46;
                            timer.Start();
                            if (QuestionNumber == 9)
                            {
                                NextQuestionButton.Text = "Закончить тестирование";
                            }
                        }
                    }
                }
                QuestionNumber++;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds == 0)
            {
                timer.Stop();
                CheckTrueOrNot();
                if (NextQuestionButton.Text == "Закончить тестирование")
                {
                    thema1.Enabled = true;
                    thema2.Enabled = true;
                    thema3.Enabled = true;
                    theoryButton.Enabled = true;
                    SecondsLeftLabel.Visible = false;
                    LeaveFromTest.Visible = false;
                    QuestionLabel.Text = $"Количество правильных ответов - {mark} из 10 \n" + ((mark > 8) ? "Оценка: 5" : (mark > 6) ? "Оценка: 4" : (mark > 5) ? "Оценка: 3" : "Оценка: 2");
                    NextQuestionButton.Visible = false;
                }
                Clear();
                NextQuestionMethod();
            }
            SecondsLeftLabel.Text = $"Оставшееся время: {seconds.ToString()}";
        }

        private void LeaveFromTest_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Вы действительно хотите покинуть тест?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {            
                Clear();
                QuestionLabel.Visible = false;
                NextQuestionButton.Visible = false;
                EvaluationCriteriaRTB.Visible = true;
                QuestionNumber = 0;
                thema1.Enabled = true;
                thema2.Enabled = true;
                thema3.Enabled = true;
                theoryButton.Enabled = true;
                SecondsLeftLabel.Visible = false;
                LeaveFromTest.Visible = false;
            }
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HidePB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void InteractiveButton_Click(object sender, EventArgs e)
        {
            Process.Start("My project.exe");
        }

        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }
    }
}

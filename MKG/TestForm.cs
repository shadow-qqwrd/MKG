using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKG
{
    public partial class TestForm : Form
    {
        int QuestionNumber = 0;
        float mark = 0;
        Test test = new Test();
        int seconds = 0;
        public TestForm()
        {
            InitializeComponent();
        }

        private void theoryButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void thema_Click(object sender, EventArgs e)
        {
            ReadyButton.Visible = true;
            XmlParser xmlParser = new XmlParser();
            test = xmlParser.GetTestByThemaName(((Button)sender).Text);
            test.questions.Shuffle();
            QuestionNameLabel.Text = test.thema;
            typesTabControl.Visible = false;
            NextQuestionFromTB.Text = "Следующий вопрос";
            NextQuestionFromCB.Text = "Следующий вопрос";
            NextQuestionFromRadio.Text = "Следующий вопрос";
            
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            typesTabControl.Visible = true;
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
            QuestionNameLabel.Text = "Выберите тему для тестирования";
        }

        private void NextQuestion_Click(object sender, EventArgs e)
        {
            CheckTrueOrNot();
            if (NextQuestionFromTB.Text == "Закончить тестирование" || NextQuestionFromCB.Text == "Закончить тестирование" || NextQuestionFromRadio.Text == "Закончить тестирование")
            {
                typesTabControl.SelectedIndex = 3;
                thema1.Enabled = true;
                thema2.Enabled = true;
                thema3.Enabled = true;
                theoryButton.Enabled = true;
                SecondsLeftLabel.Visible = false;
                LeaveFromTest.Visible = false;
                QuestionNameLabel.Text = "Результаты тестирования";
                ResultLabel.Text = $"Количество правильных ответов - {mark} из 10 \n"+((mark > 8)?"Оценка: 5":(mark > 6)?"Оценка: 4":(mark > 5)?"Оценка: 3":"Оценка: 2");

            }
            switch (typesTabControl.SelectedIndex)
            {
                case 0:
                    answerTextBox.Text = "";
                    break;
                case 1:
                    RadioPanel.Controls.Clear();
                    break;
                case 2:
                    CheckPanel.Controls.Clear();
                    break;
            }
            NextQuestionMethod();
        }
        public void CheckTrueOrNot()
        {
            int countTrue = 0;
            int count = test.questions[QuestionNumber - 1].variants.Count;
            if (count == 1)
            {
                for(int i = 0; i < count; i++)
                {
                    if (test.questions[QuestionNumber - 1].variants[i].text == answerTextBox.Text.ToLower())
                            mark++;
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (test.questions[QuestionNumber - 1].variants[i].isTrue)
                    {
                        countTrue++;
                    }
                }

                if (countTrue == 1)
                {
                    int i = 0;
                    foreach (Control control in RadioPanel.Controls)
                    {
                        if (test.questions[QuestionNumber-1].variants[i].isTrue == true)
                            if (((RadioButton)control).Checked == test.questions[QuestionNumber-1].variants[i].isTrue)
                                mark++;
                        i++;
                    }
                }
                else
                {
                    int countTrueSelected = 0;
                    int i = 0;
                    foreach (Control control in CheckPanel.Controls)
                    {
                        if (test.questions[QuestionNumber - 1].variants[i].isTrue)
                        {
                            if (((CheckBox)control).Checked == (test.questions[QuestionNumber - 1].variants[i].isTrue))
                                countTrueSelected++;
                        }
                        i++;
                    }
                    mark += (float)countTrueSelected / countTrue;
                }
            }
        }
       
        public void NextQuestionMethod()
        {
            if (QuestionNumber == 10)
            {
                NextQuestionFromTB.Text = "Закончить тестирование";
                NextQuestionFromCB.Text = "Закончить тестирование";
                NextQuestionFromRadio.Text = "Закончить тестирование";
            }
            else
            {
                int countTrue = 0;
                QuestionNameLabel.Text = (QuestionNumber+1)+". "+test.questions[QuestionNumber].text.ToString();
                int count = test.questions[QuestionNumber].variants.Count;
                if (count == 1)
                {
                    int h = 0;
                    int w = 0;
                    h = typesTabControl.Height / 2;
                    w = typesTabControl.Width / 2;
                    answerTextBox.Location = new Point(756, 442);
                    typesTabControl.SelectedIndex = 0;
                    SecondsLeftLabel.Visible = true;
                    seconds = 90;
                    timer.Start();
                    if (QuestionNumber == 9)
                    {
                        NextQuestionFromTB.Text = "Закончить тестирование";
                        NextQuestionFromCB.Text = "Закончить тестирование";
                        NextQuestionFromRadio.Text = "Закончить тестирование";
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (test.questions[QuestionNumber].variants[i].isTrue)
                        {
                            countTrue++;
                        }
                    }

                    if (countTrue == 1)
                    {
                        typesTabControl.SelectedIndex = 1;
                        for (int i = 0; i < count; i++)
                        {
                            string nameButt = "answer" + i + "RB";
                            RadioButton newButton = new RadioButton();
                            newButton.Name = nameButt;
                            newButton.Text = test.questions[QuestionNumber].variants[i].text;
                            RadioPanel.Controls.Add(newButton);
                            newButton.AutoSize = true;
                            newButton.Location = new Point(0, 40 * i);
                            SecondsLeftLabel.Visible = true;
                            seconds = 30;
                            timer.Start();
                            if (QuestionNumber == 9)
                            {
                                NextQuestionFromTB.Text = "Закончить тестирование";
                                NextQuestionFromCB.Text = "Закончить тестирование";
                                NextQuestionFromRadio.Text = "Закончить тестирование";
                            }
                        }
                    }
                    else
                    {
                        typesTabControl.SelectedIndex = 2;
                        for (int i = 0; i < count; i++)
                        {
                            string nameButt = "answer" + i + "CB";
                            CheckBox newButton = new CheckBox();
                            newButton.Name = nameButt;
                            newButton.Text = test.questions[QuestionNumber].variants[i].text;
                            CheckPanel.Controls.Add(newButton);
                            newButton.AutoSize = true;
                            newButton.Location = new Point(0, 40 * i);
                            SecondsLeftLabel.Visible = true;
                            seconds = 45;
                            timer.Start();
                            if (QuestionNumber == 9)
                            {
                                NextQuestionFromTB.Text = "Закончить тестирование";
                                NextQuestionFromCB.Text = "Закончить тестирование";
                                NextQuestionFromRadio.Text = "Закончить тестирование";
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
                NextQuestionMethod();
            }
            SecondsLeftLabel.Text = $"Оставшееся время: {seconds.ToString()}";
        }

        private void LeaveFromTest_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (DialogResult.OK == MessageBox.Show("Вы действительно хотите покинуть тест?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                QuestionNumber = 0;
                typesTabControl.Visible = false;
                QuestionNameLabel.Text = "Выберите тему для тестирования";
                thema1.Enabled = true;
                thema2.Enabled = true;
                thema3.Enabled = true;
                theoryButton.Enabled = true;
                SecondsLeftLabel.Visible = false;
                LeaveFromTest.Visible = false;
            }
            timer.Start();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

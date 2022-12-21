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
            XmlParser xmlParser = new XmlParser();
            test = xmlParser.GetTestByThemaName(((Button)sender).Text);
            test.questions.Shuffle();
            QuestionNameLabel.Text = test.thema;
            typesTabControl.Visible = false;
            QuestionNumber = 0;
            NextQuestionFromTB.Text = "Следующий вопрос";
            NextQuestionFromCB.Text = "Следующий вопрос";
            NextQuestionFromRadio.Text = "Следующий вопрос";
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            typesTabControl.Visible = true;
            NextQuestionMethod();
            mark = 0;
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
                QuestionNameLabel.Text = "Результаты тестирования";
                ResultLabel.Text = $"Result - {mark} / 10 \n"+((mark > 8)?"Krasivo!":(mark > 6)?"Normalno":"Daun chitai teoriy");
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
            int count = test.questions[QuestionNumber-1].variants.Count;
            if (count == 1)
            {
                for(int i = 0; i < count; i++)
                {
                    if (test.questions[QuestionNumber-1].variants[i].ToString() == answerTextBox.Text)
                            mark+=1;
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (test.questions[QuestionNumber-1].variants[i].isTrue)
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
                                mark+=1;
                        i++;
                    }
                }
                else
                {
                    int countTrueSelected = 0;
                    int i = 0;
                    
                    //---------GAvno peredelat
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
            if (QuestionNumber == 9)
            {
                NextQuestionFromTB.Text = "Закончить тестирование";
                NextQuestionFromCB.Text = "Закончить тестирование";
                NextQuestionFromRadio.Text = "Закончить тестирование";
            }
            else
            {
                int countTrue = 0;
                QuestionNameLabel.Text = test.questions[QuestionNumber].text.ToString();
                int count = test.questions[QuestionNumber].variants.Count;
                if (count == 1)
                {
                    typesTabControl.SelectedIndex = 0;
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (test.questions[QuestionNumber].variants[i].isTrue)
                            countTrue++;
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
                        }
                    }
                }
                QuestionNumber++;
            }
        }
    }
}

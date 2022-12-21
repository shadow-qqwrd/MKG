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
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            int countTrue = 0;
            typesTabControl.Visible = true;
            QuestionNameLabel.Text = test.questions[0].text.ToString();
            int count = test.questions[0].variants.Count;
            if (count == 1)
            {
                typesTabControl.SelectedIndex = 0;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (test.questions[0].variants[i].isTrue)
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
                        newButton.Location = new Point(0, 40 * i);
                        newButton.Text = test.questions[0].variants[i].text;
                        RadioPanel.Controls.Add(newButton);
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
                        newButton.Location = new Point(0, 40 * i);
                        newButton.Text = test.questions[0].variants[i].text;
                        CheckPanel.Controls.Add(newButton);
                    }
                }
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            QuestionNameLabel.Text = "Выберите тему для тестирования";
        }

        private void NextQuestion_Click(object sender, EventArgs e)
        {
            if (NextQuestionFromTB.Text == "Закончить тестирование" || NextQuestionFromCB.Text == "Закончить тестирование" || NextQuestionFromRadio.Text == "Закончить тестирование")
            {
                typesTabControl.SelectedIndex = 3;

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
                typesTabControl.Visible = true;
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
                        //answer1RB.Text = test.questions[QuestionNumber].variants[0].text;
                        //Point point = new Point(0, 0);
                        //answer1RB.Location = point;
                        for (int i = 1; i < count; i++)
                        {
                            string nameButt = "answer" + i + "RB";
                            RadioButton newButton = new RadioButton();
                            newButton.Name = nameButt;
                            newButton.Location = new Point(0, 40 * i);
                            newButton.Text = test.questions[QuestionNumber].variants[i].text;
                            RadioPanel.Controls.Add(newButton);
                        }
                    }
                    else
                    {
                        typesTabControl.SelectedIndex = 2;
                        //answer1CB.Text = test.questions[QuestionNumber].variants[0].text;
                        //Point point = new Point();
                        //answer1CB.Location = point;
                        for (int i = 0; i < count; i++)
                        {
                            string nameButt = "answer" + i + "CB";
                            CheckBox newButton = new CheckBox();
                            newButton.Name = nameButt;
                            newButton.Location = new Point(0, 40 * i);
                            newButton.Text = test.questions[QuestionNumber].variants[i].text;
                            CheckPanel.Controls.Add(newButton);
                        }
                    }
                }
                QuestionNumber++;
            }
        }
    }
}

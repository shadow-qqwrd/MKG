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
            typesTabControl.Visible = true;
            QuestionNameLabel.Text = test.questions[0].text.ToString();
            test.
        }
    }
}

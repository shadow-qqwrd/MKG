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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void thema_Click(object sender, EventArgs e)
        {
            try
            {
                infoRTB.ReadOnly = false;
                infoRTB.LoadFile($"{((Button)sender).Text}.rtf");
                infoRTB.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestForm_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
            this.Hide();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HidePB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgramForm = new AboutProgramForm();
            aboutProgramForm.Show();
        }
    }
}

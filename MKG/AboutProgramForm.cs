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
    public partial class AboutProgramForm : Form
    {
        public AboutProgramForm()
        {
            InitializeComponent();
        }
        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HidePB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AboutProgramForm_Load(object sender, EventArgs e)
        {
            AboutRTB.Text = "Обучающая программа «Разновидности механических клавиатур, их техническое обслуживание и компоненты»\n \n\n\n\nРазработчик: Шевцов Артём Олегович, группа ПКС-91\n\n\n\n\n version 1.0\n\n";
            AboutRTB.SelectAll();
            AboutRTB.SelectionAlignment = HorizontalAlignment.Center;
            AboutRTB.SelectionFont = new Font("Lucinda Console", 48);
        }

        private void TheoryForm_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}

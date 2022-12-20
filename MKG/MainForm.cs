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
    }
}

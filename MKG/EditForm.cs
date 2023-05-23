using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;
using ToolTip = System.Windows.Forms.ToolTip;

namespace MKG
{
    public partial class EditForm : Form
    {
        float[] sizes = new float[] {8, 9, 10, 11, 12, 14, 16, 18, 
                                 20, 22, 24, 26, 28, 36, 48, 72 };
        FontFamily[] fonts;
        Test test = new Test();
        string path;
        List<string> themaNames = new List<string>();
        ComboBox combo = new ComboBox();
        DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());

        public EditForm()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            t.SetToolTip(BoldFontButton, "Полужирный");
            t.SetToolTip(ItalicFontButton, "Курсив");
            t.SetToolTip(UnderlineFontButton, "Подчеркнутый");
            t.SetToolTip(SaveButton, "Сохранить");
            t.SetToolTip(theoryButton, "Назад к теории");
            t.SetToolTip(leftButton, "Выровнять по левому краю");
            t.SetToolTip(centerButton, "Выровнять по центру");
            t.SetToolTip(rightButton, "Выровнять по правому краю");
            t.SetToolTip(eraserButton, "Сбросить форматирование");
        }

        private void CheckAdminForm_Load(object sender, EventArgs e)
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach (float item in sizes)
            {
                fontSizeCB.Items.Add(item);
            }
            fontSizeCB.SelectedIndex = 0;
            fonts = installedFontCollection.Families;
            for (int i = 0; i < fonts.Length; i++)
            {
                fontsCB.Items.Add(fonts[i].Name);
            }
            fontsCB.SelectedIndex = 0;
            SearchRTF();
            CreateComboBox();
        }
        private void SearchRTF()
        {
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                if (Path.GetExtension(file.FullName) == ".rtf")
                    themaNames.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
        }

        public void CreateComboBox()
        {
            panel3.Controls.Add(combo);
            for (int i = 0; i < themaNames.Count; i++)
            {
                combo.Items.Add(themaNames[i]);
            }
            combo.Height = 23;
            combo.Width = fontsCB.Location.X - 42;
            combo.Location = new Point(31, 3);
            combo.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            combo.SelectedIndex = 0;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void HidePB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContentRTB.LoadFile($"{((ComboBox)sender).SelectedItem}.rtf");
        } 

        private void SaveButton_Click(object sender, EventArgs e) 
        {
            try
            {
                path = directoryInfo.FullName + $"\\{combo.SelectedItem.ToString()}.rtf";
                ContentRTB.SaveFile(path);
                MessageBox.Show("Файл успешно сохранен!", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void theoryButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void BoldFontButton_Click(object sender, EventArgs e)
        {
            if (ContentRTB.SelectionFont != null)
            {
                Font currentFont = ContentRTB.SelectionFont;
                FontStyle newFontStyle;
                if (ContentRTB.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }
                ContentRTB.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle);
            }

        }

        private void ItalicFontButton_Click(object sender, EventArgs e)
        {
            if (ContentRTB.SelectionFont != null)
            {
                Font currentFont = ContentRTB.SelectionFont;
                FontStyle newFontStyle;
                if (ContentRTB.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }
                ContentRTB.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle);
            }
        }

        private void UnderlineFontButton_Click(object sender, EventArgs e)
        {
            if (ContentRTB.SelectionFont != null)
            {
                Font currentFont = ContentRTB.SelectionFont;
                FontStyle newFontStyle;
                if (ContentRTB.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                }
                ContentRTB.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle);
            }
        }

        private void AddContentButton_Click(object sender, EventArgs e) 
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF files (*.rtf)|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists($"{directoryInfo.FullName}\\{Path.GetFileName(openFileDialog.FileName)}"))
                {
                    DialogResult dialog = MessageBox.Show("Перезаписать файл?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        File.Delete($"{directoryInfo.FullName}\\{Path.GetFileName(openFileDialog.FileName)}");
                        File.Copy(openFileDialog.FileName, $"{directoryInfo.FullName}\\{Path.GetFileName(openFileDialog.FileName)}");
                        combo.Items.Clear();
                        panel3.Controls.Remove(combo);
                        foreach (FileInfo file in directoryInfo.GetFiles())
                        {
                            if (Path.GetExtension(file.FullName) == ".rtf")
                            {
                                themaNames.Add(Path.GetFileNameWithoutExtension(file.Name));
                            }
                        }
                        panel3.Controls.Add(combo);
                    }
                }
                else
                {
                    File.Copy(openFileDialog.FileName, $"{directoryInfo.FullName}\\{Path.GetFileName(openFileDialog.FileName)}");
                    themaNames.Clear();
                    panel3.Controls.Remove(combo);
                    foreach (FileInfo file in directoryInfo.GetFiles())
                    {
                        if (Path.GetExtension(file.FullName) == ".rtf")
                        {
                            themaNames.Add(Path.GetFileNameWithoutExtension(file.Name));
                        }
                    }
                    panel3.Controls.Add(combo);
                    MessageBox.Show("Файл успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            ContentRTB.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            ContentRTB.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            ContentRTB.SelectionAlignment = HorizontalAlignment.Right;
        }
       
        private void fontSizeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContentRTB.SelectionFont == null)
            {
                MessageBox.Show("Выберите одинаково отформатированный текст или воспользуйтесь сбросом форматирования" , "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Font currentFont = ContentRTB.SelectionFont;
                ContentRTB.SelectionFont = new Font(currentFont.FontFamily, float.Parse(fontSizeCB.SelectedItem.ToString()), FontStyle.Regular);
            }
            
        }

        private void fontsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContentRTB.SelectionFont == null)
            {
                var currFont = fontsCB.Text;
                float size = (float)fontSizeCB.SelectedItem;
                ContentRTB.SelectionFont = new Font(currFont, size, FontStyle.Regular);
            }
            else
            {
                Font currentFont = ContentRTB.SelectionFont;
                ContentRTB.SelectionFont = new Font(fontsCB.Text, currentFont.Size, FontStyle.Regular);
            }
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            ContentRTB.SelectionColor = Color.Black;
            ContentRTB.SelectionFont = new Font("Times New Roman", 14, FontStyle.Regular);
        }
    }
}


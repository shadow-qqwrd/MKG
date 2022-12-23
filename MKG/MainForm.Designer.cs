
namespace MKG
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.thema1 = new System.Windows.Forms.Button();
            this.infoRTB = new System.Windows.Forms.RichTextBox();
            this.thema2 = new System.Windows.Forms.Button();
            this.thema3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TestForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // thema1
            // 
            this.thema1.Location = new System.Drawing.Point(8, 45);
            this.thema1.Name = "thema1";
            this.thema1.Size = new System.Drawing.Size(179, 45);
            this.thema1.TabIndex = 0;
            this.thema1.Text = "Что такое механическая клавиатура";
            this.thema1.UseVisualStyleBackColor = true;
            this.thema1.Click += new System.EventHandler(this.thema_Click);
            // 
            // infoRTB
            // 
            this.infoRTB.BackColor = System.Drawing.Color.Gainsboro;
            this.infoRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoRTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infoRTB.Location = new System.Drawing.Point(0, 0);
            this.infoRTB.Name = "infoRTB";
            this.infoRTB.Size = new System.Drawing.Size(610, 451);
            this.infoRTB.TabIndex = 1;
            this.infoRTB.Text = "";
            // 
            // thema2
            // 
            this.thema2.Location = new System.Drawing.Point(8, 96);
            this.thema2.Name = "thema2";
            this.thema2.Size = new System.Drawing.Size(179, 35);
            this.thema2.TabIndex = 2;
            this.thema2.Text = "Переключатели и стабилизаторы";
            this.thema2.UseVisualStyleBackColor = true;
            this.thema2.Click += new System.EventHandler(this.thema_Click);
            // 
            // thema3
            // 
            this.thema3.Location = new System.Drawing.Point(8, 137);
            this.thema3.Name = "thema3";
            this.thema3.Size = new System.Drawing.Size(179, 33);
            this.thema3.TabIndex = 3;
            this.thema3.Text = "Кейкапы";
            this.thema3.UseVisualStyleBackColor = true;
            this.thema3.Click += new System.EventHandler(this.thema_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TestForm);
            this.panel1.Controls.Add(this.thema1);
            this.panel1.Controls.Add(this.thema3);
            this.panel1.Controls.Add(this.thema2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 451);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Теория";
            // 
            // TestForm
            // 
            this.TestForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TestForm.Location = new System.Drawing.Point(12, 408);
            this.TestForm.Name = "TestForm";
            this.TestForm.Size = new System.Drawing.Size(170, 31);
            this.TestForm.TabIndex = 5;
            this.TestForm.Text = "Перейти к тестированию";
            this.TestForm.UseVisualStyleBackColor = true;
            this.TestForm.Click += new System.EventHandler(this.TestForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.exitBox);
            this.panel2.Controls.Add(this.infoRTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 451);
            this.panel2.TabIndex = 5;
            // 
            // exitBox
            // 
            this.exitBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBox.BackColor = System.Drawing.Color.White;
            this.exitBox.Image = global::MKG.Properties.Resources.ext1;
            this.exitBox.Location = new System.Drawing.Point(559, 3);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(48, 45);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBox.TabIndex = 11;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MKG.Properties.Resources._123312123312;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button thema1;
        private System.Windows.Forms.RichTextBox infoRTB;
        private System.Windows.Forms.Button thema2;
        private System.Windows.Forms.Button thema3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TestForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox exitBox;
    }
}
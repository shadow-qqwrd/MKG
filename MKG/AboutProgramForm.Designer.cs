
namespace MKG
{
    partial class AboutProgramForm
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
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.TheoryForm = new System.Windows.Forms.Button();
            this.HidePB = new System.Windows.Forms.PictureBox();
            this.AboutRTB = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePB)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBox
            // 
            this.exitBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBox.BackColor = System.Drawing.Color.White;
            this.exitBox.Image = global::MKG.Properties.Resources.ext1;
            this.exitBox.Location = new System.Drawing.Point(775, 3);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(22, 22);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBox.TabIndex = 13;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // TheoryForm
            // 
            this.TheoryForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TheoryForm.Location = new System.Drawing.Point(12, 407);
            this.TheoryForm.Name = "TheoryForm";
            this.TheoryForm.Size = new System.Drawing.Size(170, 31);
            this.TheoryForm.TabIndex = 15;
            this.TheoryForm.Text = "Перейти к теории";
            this.TheoryForm.UseVisualStyleBackColor = true;
            this.TheoryForm.Click += new System.EventHandler(this.TheoryForm_Click);
            // 
            // HidePB
            // 
            this.HidePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HidePB.Image = global::MKG.Properties.Resources.sver;
            this.HidePB.Location = new System.Drawing.Point(747, 3);
            this.HidePB.Name = "HidePB";
            this.HidePB.Size = new System.Drawing.Size(22, 22);
            this.HidePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HidePB.TabIndex = 14;
            this.HidePB.TabStop = false;
            this.HidePB.Click += new System.EventHandler(this.HidePB_Click);
            // 
            // AboutRTB
            // 
            this.AboutRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutRTB.BackColor = System.Drawing.Color.Gainsboro;
            this.AboutRTB.Location = new System.Drawing.Point(12, 31);
            this.AboutRTB.Name = "AboutRTB";
            this.AboutRTB.Size = new System.Drawing.Size(776, 370);
            this.AboutRTB.TabIndex = 16;
            this.AboutRTB.Text = "";
            // 
            // AboutProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AboutRTB);
            this.Controls.Add(this.TheoryForm);
            this.Controls.Add(this.HidePB);
            this.Controls.Add(this.exitBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutProgramForm";
            this.Text = "О программе";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AboutProgramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.Button TheoryForm;
        private System.Windows.Forms.PictureBox HidePB;
        private System.Windows.Forms.RichTextBox AboutRTB;
    }
}
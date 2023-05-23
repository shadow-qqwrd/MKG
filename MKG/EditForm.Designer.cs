namespace MKG
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.theoryButton = new System.Windows.Forms.Button();
            this.UnderlineFontButton = new System.Windows.Forms.Button();
            this.ItalicFontButton = new System.Windows.Forms.Button();
            this.BoldFontButton = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContentRTB = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eraserButton = new System.Windows.Forms.Button();
            this.fontsCB = new System.Windows.Forms.ComboBox();
            this.fontSizeCB = new System.Windows.Forms.ComboBox();
            this.rightButton = new System.Windows.Forms.Button();
            this.centerButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.HidePB = new System.Windows.Forms.PictureBox();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.editPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HidePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // theoryButton
            // 
            this.theoryButton.BackColor = System.Drawing.Color.White;
            this.theoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("theoryButton.BackgroundImage")));
            this.theoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.theoryButton.FlatAppearance.BorderSize = 0;
            this.theoryButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.theoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.theoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.theoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theoryButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.theoryButton.Location = new System.Drawing.Point(3, 3);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(22, 22);
            this.theoryButton.TabIndex = 6;
            this.theoryButton.UseVisualStyleBackColor = false;
            this.theoryButton.Click += new System.EventHandler(this.theoryButton_Click);
            // 
            // UnderlineFontButton
            // 
            this.UnderlineFontButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderlineFontButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UnderlineFontButton.BackgroundImage")));
            this.UnderlineFontButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UnderlineFontButton.Location = new System.Drawing.Point(691, 3);
            this.UnderlineFontButton.Name = "UnderlineFontButton";
            this.UnderlineFontButton.Size = new System.Drawing.Size(22, 22);
            this.UnderlineFontButton.TabIndex = 2;
            this.UnderlineFontButton.UseVisualStyleBackColor = true;
            this.UnderlineFontButton.Click += new System.EventHandler(this.UnderlineFontButton_Click);
            // 
            // ItalicFontButton
            // 
            this.ItalicFontButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ItalicFontButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ItalicFontButton.BackgroundImage")));
            this.ItalicFontButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ItalicFontButton.Location = new System.Drawing.Point(663, 3);
            this.ItalicFontButton.Name = "ItalicFontButton";
            this.ItalicFontButton.Size = new System.Drawing.Size(22, 22);
            this.ItalicFontButton.TabIndex = 1;
            this.ItalicFontButton.UseVisualStyleBackColor = true;
            this.ItalicFontButton.Click += new System.EventHandler(this.ItalicFontButton_Click);
            // 
            // BoldFontButton
            // 
            this.BoldFontButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoldFontButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoldFontButton.BackgroundImage")));
            this.BoldFontButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BoldFontButton.Location = new System.Drawing.Point(635, 3);
            this.BoldFontButton.Name = "BoldFontButton";
            this.BoldFontButton.Size = new System.Drawing.Size(22, 22);
            this.BoldFontButton.TabIndex = 0;
            this.BoldFontButton.UseVisualStyleBackColor = true;
            this.BoldFontButton.Click += new System.EventHandler(this.BoldFontButton_Click);
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.Transparent;
            this.editPanel.Controls.Add(this.panel1);
            this.editPanel.Controls.Add(this.panel3);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(800, 450);
            this.editPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ContentRTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 422);
            this.panel1.TabIndex = 14;
            // 
            // ContentRTB
            // 
            this.ContentRTB.BackColor = System.Drawing.SystemColors.Window;
            this.ContentRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentRTB.Location = new System.Drawing.Point(0, 0);
            this.ContentRTB.Name = "ContentRTB";
            this.ContentRTB.Size = new System.Drawing.Size(800, 422);
            this.ContentRTB.TabIndex = 0;
            this.ContentRTB.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.eraserButton);
            this.panel3.Controls.Add(this.fontsCB);
            this.panel3.Controls.Add(this.fontSizeCB);
            this.panel3.Controls.Add(this.rightButton);
            this.panel3.Controls.Add(this.centerButton);
            this.panel3.Controls.Add(this.leftButton);
            this.panel3.Controls.Add(this.theoryButton);
            this.panel3.Controls.Add(this.SaveButton);
            this.panel3.Controls.Add(this.HidePB);
            this.panel3.Controls.Add(this.UnderlineFontButton);
            this.panel3.Controls.Add(this.ItalicFontButton);
            this.panel3.Controls.Add(this.exitBox);
            this.panel3.Controls.Add(this.BoldFontButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 28);
            this.panel3.TabIndex = 13;
            // 
            // eraserButton
            // 
            this.eraserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eraserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraserButton.BackgroundImage")));
            this.eraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraserButton.Location = new System.Drawing.Point(523, 3);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(22, 22);
            this.eraserButton.TabIndex = 19;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // fontsCB
            // 
            this.fontsCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontsCB.FormattingEnabled = true;
            this.fontsCB.Location = new System.Drawing.Point(260, 3);
            this.fontsCB.Name = "fontsCB";
            this.fontsCB.Size = new System.Drawing.Size(205, 21);
            this.fontsCB.TabIndex = 18;
            this.fontsCB.SelectedIndexChanged += new System.EventHandler(this.fontsCB_SelectedIndexChanged);
            // 
            // fontSizeCB
            // 
            this.fontSizeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontSizeCB.DropDownHeight = 112;
            this.fontSizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontSizeCB.FormattingEnabled = true;
            this.fontSizeCB.IntegralHeight = false;
            this.fontSizeCB.Location = new System.Drawing.Point(471, 3);
            this.fontSizeCB.Name = "fontSizeCB";
            this.fontSizeCB.Size = new System.Drawing.Size(46, 21);
            this.fontSizeCB.TabIndex = 17;
            this.fontSizeCB.SelectedIndexChanged += new System.EventHandler(this.fontSizeCB_SelectedIndexChanged);
            // 
            // rightButton
            // 
            this.rightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightButton.BackgroundImage")));
            this.rightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightButton.Location = new System.Drawing.Point(607, 3);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(22, 22);
            this.rightButton.TabIndex = 15;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // centerButton
            // 
            this.centerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.centerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("centerButton.BackgroundImage")));
            this.centerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.centerButton.Location = new System.Drawing.Point(579, 3);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(22, 22);
            this.centerButton.TabIndex = 14;
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.centerButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leftButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftButton.BackgroundImage")));
            this.leftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftButton.Location = new System.Drawing.Point(551, 3);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(22, 22);
            this.leftButton.TabIndex = 13;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Location = new System.Drawing.Point(719, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(22, 22);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // HidePB
            // 
            this.HidePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HidePB.Image = global::MKG.Properties.Resources.sver;
            this.HidePB.Location = new System.Drawing.Point(747, 3);
            this.HidePB.Name = "HidePB";
            this.HidePB.Size = new System.Drawing.Size(22, 22);
            this.HidePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HidePB.TabIndex = 12;
            this.HidePB.TabStop = false;
            this.HidePB.Click += new System.EventHandler(this.HidePB_Click);
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
            this.exitBox.TabIndex = 11;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MKG.Properties.Resources._123312123312;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Администрирование";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckAdminForm_Load);
            this.editPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HidePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.RichTextBox ContentRTB;
        private System.Windows.Forms.Button UnderlineFontButton;
        private System.Windows.Forms.Button ItalicFontButton;
        private System.Windows.Forms.Button BoldFontButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox HidePB;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.Button theoryButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.ComboBox fontSizeCB;
        private System.Windows.Forms.ComboBox fontsCB;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.FontDialog FontDialog;
    }
}

namespace MKG
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.ThemasPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.theoryButton = new System.Windows.Forms.Button();
            this.thema1 = new System.Windows.Forms.Button();
            this.thema3 = new System.Windows.Forms.Button();
            this.thema2 = new System.Windows.Forms.Button();
            this.LeaveFromTest = new System.Windows.Forms.Button();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.SecondsLeftLabel = new System.Windows.Forms.Label();
            this.QuestionsPanel = new System.Windows.Forms.Panel();
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.EvaluationCriteriaRTB = new System.Windows.Forms.RichTextBox();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.HidePB = new System.Windows.Forms.PictureBox();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.InteractiveButton = new System.Windows.Forms.Button();
            this.ThemasPanel.SuspendLayout();
            this.QuestionsPanel.SuspendLayout();
            this.AnswersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePB)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemasPanel
            // 
            this.ThemasPanel.BackColor = System.Drawing.Color.Transparent;
            this.ThemasPanel.Controls.Add(this.InteractiveButton);
            this.ThemasPanel.Controls.Add(this.label1);
            this.ThemasPanel.Controls.Add(this.theoryButton);
            this.ThemasPanel.Controls.Add(this.thema1);
            this.ThemasPanel.Controls.Add(this.thema3);
            this.ThemasPanel.Controls.Add(this.thema2);
            this.ThemasPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThemasPanel.Location = new System.Drawing.Point(0, 0);
            this.ThemasPanel.Name = "ThemasPanel";
            this.ThemasPanel.Size = new System.Drawing.Size(301, 704);
            this.ThemasPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тестирование";
            // 
            // theoryButton
            // 
            this.theoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.theoryButton.BackColor = System.Drawing.Color.Transparent;
            this.theoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("theoryButton.BackgroundImage")));
            this.theoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.theoryButton.FlatAppearance.BorderSize = 0;
            this.theoryButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.theoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.theoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.theoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theoryButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.theoryButton.Location = new System.Drawing.Point(12, 595);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(260, 100);
            this.theoryButton.TabIndex = 5;
            this.theoryButton.Text = "Перейти к теории";
            this.theoryButton.UseVisualStyleBackColor = false;
            this.theoryButton.Click += new System.EventHandler(this.theoryButton_Click);
            // 
            // thema1
            // 
            this.thema1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thema1.BackgroundImage")));
            this.thema1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.thema1.FlatAppearance.BorderSize = 0;
            this.thema1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.thema1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.thema1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.thema1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thema1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thema1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thema1.Location = new System.Drawing.Point(12, 57);
            this.thema1.Name = "thema1";
            this.thema1.Size = new System.Drawing.Size(260, 100);
            this.thema1.TabIndex = 0;
            this.thema1.Text = "Что такое механическая клавиатура";
            this.thema1.UseVisualStyleBackColor = true;
            this.thema1.Click += new System.EventHandler(this.thema_Click);
            // 
            // thema3
            // 
            this.thema3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thema3.BackgroundImage")));
            this.thema3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.thema3.FlatAppearance.BorderSize = 0;
            this.thema3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.thema3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.thema3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.thema3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thema3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thema3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thema3.Location = new System.Drawing.Point(12, 163);
            this.thema3.Name = "thema3";
            this.thema3.Size = new System.Drawing.Size(260, 100);
            this.thema3.TabIndex = 3;
            this.thema3.Text = "Кейкапы";
            this.thema3.UseVisualStyleBackColor = true;
            this.thema3.Click += new System.EventHandler(this.thema_Click);
            // 
            // thema2
            // 
            this.thema2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thema2.BackgroundImage")));
            this.thema2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.thema2.FlatAppearance.BorderSize = 0;
            this.thema2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.thema2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.thema2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.thema2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thema2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thema2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thema2.Location = new System.Drawing.Point(12, 273);
            this.thema2.Name = "thema2";
            this.thema2.Size = new System.Drawing.Size(260, 100);
            this.thema2.TabIndex = 2;
            this.thema2.Text = "Переключатели и стабилизаторы";
            this.thema2.UseVisualStyleBackColor = true;
            this.thema2.Click += new System.EventHandler(this.thema_Click);
            // 
            // LeaveFromTest
            // 
            this.LeaveFromTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaveFromTest.BackColor = System.Drawing.Color.Transparent;
            this.LeaveFromTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeaveFromTest.BackgroundImage")));
            this.LeaveFromTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeaveFromTest.FlatAppearance.BorderSize = 0;
            this.LeaveFromTest.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.LeaveFromTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LeaveFromTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.LeaveFromTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveFromTest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaveFromTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LeaveFromTest.Location = new System.Drawing.Point(667, 45);
            this.LeaveFromTest.Name = "LeaveFromTest";
            this.LeaveFromTest.Size = new System.Drawing.Size(260, 100);
            this.LeaveFromTest.TabIndex = 9;
            this.LeaveFromTest.Text = "Выйти из теста";
            this.LeaveFromTest.UseVisualStyleBackColor = false;
            this.LeaveFromTest.Visible = false;
            this.LeaveFromTest.Click += new System.EventHandler(this.LeaveFromTest_Click);
            // 
            // ReadyButton
            // 
            this.ReadyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadyButton.BackColor = System.Drawing.Color.Transparent;
            this.ReadyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReadyButton.BackgroundImage")));
            this.ReadyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReadyButton.FlatAppearance.BorderSize = 0;
            this.ReadyButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ReadyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReadyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReadyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadyButton.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReadyButton.Location = new System.Drawing.Point(153, 131);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(616, 253);
            this.ReadyButton.TabIndex = 8;
            this.ReadyButton.Text = "Начать тестирование";
            this.ReadyButton.UseVisualStyleBackColor = false;
            this.ReadyButton.Visible = false;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // SecondsLeftLabel
            // 
            this.SecondsLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SecondsLeftLabel.AutoSize = true;
            this.SecondsLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.SecondsLeftLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondsLeftLabel.ForeColor = System.Drawing.Color.Transparent;
            this.SecondsLeftLabel.Location = new System.Drawing.Point(30, 655);
            this.SecondsLeftLabel.Name = "SecondsLeftLabel";
            this.SecondsLeftLabel.Size = new System.Drawing.Size(0, 24);
            this.SecondsLeftLabel.TabIndex = 9;
            this.SecondsLeftLabel.Visible = false;
            // 
            // QuestionsPanel
            // 
            this.QuestionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionsPanel.Controls.Add(this.AnswersPanel);
            this.QuestionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionsPanel.Location = new System.Drawing.Point(301, 0);
            this.QuestionsPanel.Name = "QuestionsPanel";
            this.QuestionsPanel.Size = new System.Drawing.Size(931, 704);
            this.QuestionsPanel.TabIndex = 7;
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.BackColor = System.Drawing.Color.DarkGray;
            this.AnswersPanel.BackgroundImage = global::MKG.Properties.Resources.image;
            this.AnswersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnswersPanel.Controls.Add(this.QuestionLabel);
            this.AnswersPanel.Controls.Add(this.EvaluationCriteriaRTB);
            this.AnswersPanel.Controls.Add(this.ReadyButton);
            this.AnswersPanel.Controls.Add(this.LeaveFromTest);
            this.AnswersPanel.Controls.Add(this.exitBox);
            this.AnswersPanel.Controls.Add(this.SecondsLeftLabel);
            this.AnswersPanel.Controls.Add(this.HidePB);
            this.AnswersPanel.Controls.Add(this.NextQuestionButton);
            this.AnswersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswersPanel.Location = new System.Drawing.Point(0, 0);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(931, 704);
            this.AnswersPanel.TabIndex = 1;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(365, 172);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(900, 200);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(181, 28);
            this.QuestionLabel.TabIndex = 14;
            this.QuestionLabel.Text = "Текст вопроса";
            this.QuestionLabel.Visible = false;
            // 
            // EvaluationCriteriaRTB
            // 
            this.EvaluationCriteriaRTB.BackColor = System.Drawing.Color.Gainsboro;
            this.EvaluationCriteriaRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluationCriteriaRTB.Location = new System.Drawing.Point(0, 0);
            this.EvaluationCriteriaRTB.Name = "EvaluationCriteriaRTB";
            this.EvaluationCriteriaRTB.ReadOnly = true;
            this.EvaluationCriteriaRTB.Size = new System.Drawing.Size(931, 704);
            this.EvaluationCriteriaRTB.TabIndex = 10;
            this.EvaluationCriteriaRTB.Text = "";
            // 
            // exitBox
            // 
            this.exitBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBox.BackColor = System.Drawing.Color.White;
            this.exitBox.Image = global::MKG.Properties.Resources.ext1;
            this.exitBox.Location = new System.Drawing.Point(905, 3);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(22, 22);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBox.TabIndex = 10;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // HidePB
            // 
            this.HidePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HidePB.Image = global::MKG.Properties.Resources.sver;
            this.HidePB.Location = new System.Drawing.Point(881, 3);
            this.HidePB.Name = "HidePB";
            this.HidePB.Size = new System.Drawing.Size(22, 22);
            this.HidePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HidePB.TabIndex = 13;
            this.HidePB.TabStop = false;
            this.HidePB.Click += new System.EventHandler(this.HidePB_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestionButton.BackColor = System.Drawing.Color.Transparent;
            this.NextQuestionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextQuestionButton.BackgroundImage")));
            this.NextQuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextQuestionButton.FlatAppearance.BorderSize = 0;
            this.NextQuestionButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.NextQuestionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NextQuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.NextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextQuestionButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.NextQuestionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NextQuestionButton.Location = new System.Drawing.Point(667, 592);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(260, 100);
            this.NextQuestionButton.TabIndex = 8;
            this.NextQuestionButton.Tag = "";
            this.NextQuestionButton.Text = "Следующий вопрос";
            this.NextQuestionButton.UseVisualStyleBackColor = false;
            this.NextQuestionButton.Visible = false;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestion_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // InteractiveButton
            // 
            this.InteractiveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InteractiveButton.BackgroundImage")));
            this.InteractiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InteractiveButton.FlatAppearance.BorderSize = 0;
            this.InteractiveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.InteractiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.InteractiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.InteractiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InteractiveButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InteractiveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InteractiveButton.Location = new System.Drawing.Point(12, 379);
            this.InteractiveButton.Name = "InteractiveButton";
            this.InteractiveButton.Size = new System.Drawing.Size(260, 100);
            this.InteractiveButton.TabIndex = 7;
            this.InteractiveButton.Text = "Запустить интерактив";
            this.InteractiveButton.UseVisualStyleBackColor = true;
            this.InteractiveButton.Click += new System.EventHandler(this.InteractiveButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MKG.Properties.Resources._123312123312;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 704);
            this.Controls.Add(this.QuestionsPanel);
            this.Controls.Add(this.ThemasPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.Text = "Тестирование";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ThemasPanel.ResumeLayout(false);
            this.ThemasPanel.PerformLayout();
            this.QuestionsPanel.ResumeLayout(false);
            this.AnswersPanel.ResumeLayout(false);
            this.AnswersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ThemasPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button theoryButton;
        private System.Windows.Forms.Button thema1;
        private System.Windows.Forms.Button thema3;
        private System.Windows.Forms.Button thema2;
        private System.Windows.Forms.Panel QuestionsPanel;
        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label SecondsLeftLabel;
        private System.Windows.Forms.Button LeaveFromTest;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox HidePB;
        private System.Windows.Forms.RichTextBox EvaluationCriteriaRTB;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button InteractiveButton;
    }
}
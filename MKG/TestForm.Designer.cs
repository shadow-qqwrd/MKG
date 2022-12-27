
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
            this.LeaveFromTest = new System.Windows.Forms.Button();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.theoryButton = new System.Windows.Forms.Button();
            this.thema1 = new System.Windows.Forms.Button();
            this.thema3 = new System.Windows.Forms.Button();
            this.thema2 = new System.Windows.Forms.Button();
            this.SecondsLeftLabel = new System.Windows.Forms.Label();
            this.NextQuestionFromCB = new System.Windows.Forms.Button();
            this.QuestionsPanel = new System.Windows.Forms.Panel();
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.EvaluationCriteriaRTB = new System.Windows.Forms.RichTextBox();
            this.typesTabControl = new System.Windows.Forms.TabControl();
            this.tbPage = new System.Windows.Forms.TabPage();
            this.QuestionNameLabel = new System.Windows.Forms.Label();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.HidePB = new System.Windows.Forms.PictureBox();
            this.NextQuestionFromTB = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.rbPage = new System.Windows.Forms.TabPage();
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NextQuestionFromRadio = new System.Windows.Forms.Button();
            this.cbPage = new System.Windows.Forms.TabPage();
            this.CheckPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.resultPage = new System.Windows.Forms.TabPage();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ThemasPanel.SuspendLayout();
            this.QuestionsPanel.SuspendLayout();
            this.AnswersPanel.SuspendLayout();
            this.typesTabControl.SuspendLayout();
            this.tbPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePB)).BeginInit();
            this.rbPage.SuspendLayout();
            this.RadioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cbPage.SuspendLayout();
            this.CheckPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.resultPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThemasPanel
            // 
            this.ThemasPanel.BackColor = System.Drawing.Color.Transparent;
            this.ThemasPanel.Controls.Add(this.LeaveFromTest);
            this.ThemasPanel.Controls.Add(this.ReadyButton);
            this.ThemasPanel.Controls.Add(this.label1);
            this.ThemasPanel.Controls.Add(this.theoryButton);
            this.ThemasPanel.Controls.Add(this.thema1);
            this.ThemasPanel.Controls.Add(this.thema3);
            this.ThemasPanel.Controls.Add(this.thema2);
            this.ThemasPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThemasPanel.Location = new System.Drawing.Point(0, 0);
            this.ThemasPanel.Name = "ThemasPanel";
            this.ThemasPanel.Size = new System.Drawing.Size(190, 498);
            this.ThemasPanel.TabIndex = 6;
            // 
            // LeaveFromTest
            // 
            this.LeaveFromTest.Location = new System.Drawing.Point(43, 354);
            this.LeaveFromTest.Name = "LeaveFromTest";
            this.LeaveFromTest.Size = new System.Drawing.Size(126, 28);
            this.LeaveFromTest.TabIndex = 9;
            this.LeaveFromTest.Text = "Выйти из теста";
            this.LeaveFromTest.UseVisualStyleBackColor = true;
            this.LeaveFromTest.Visible = false;
            this.LeaveFromTest.Click += new System.EventHandler(this.LeaveFromTest_Click);
            // 
            // ReadyButton
            // 
            this.ReadyButton.Location = new System.Drawing.Point(12, 414);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(170, 35);
            this.ReadyButton.TabIndex = 8;
            this.ReadyButton.Text = "Начать тестирование";
            this.ReadyButton.UseVisualStyleBackColor = true;
            this.ReadyButton.Visible = false;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тестирование";
            // 
            // theoryButton
            // 
            this.theoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.theoryButton.Location = new System.Drawing.Point(12, 455);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(170, 31);
            this.theoryButton.TabIndex = 5;
            this.theoryButton.Text = "Перейти к теории";
            this.theoryButton.UseVisualStyleBackColor = true;
            this.theoryButton.Click += new System.EventHandler(this.theoryButton_Click);
            // 
            // thema1
            // 
            this.thema1.Location = new System.Drawing.Point(6, 45);
            this.thema1.Name = "thema1";
            this.thema1.Size = new System.Drawing.Size(179, 45);
            this.thema1.TabIndex = 0;
            this.thema1.Text = "Что такое механическая клавиатура";
            this.thema1.UseVisualStyleBackColor = true;
            this.thema1.Click += new System.EventHandler(this.thema_Click);
            // 
            // thema3
            // 
            this.thema3.Location = new System.Drawing.Point(6, 137);
            this.thema3.Name = "thema3";
            this.thema3.Size = new System.Drawing.Size(179, 33);
            this.thema3.TabIndex = 3;
            this.thema3.Text = "Кейкапы";
            this.thema3.UseVisualStyleBackColor = true;
            this.thema3.Click += new System.EventHandler(this.thema_Click);
            // 
            // thema2
            // 
            this.thema2.Location = new System.Drawing.Point(6, 96);
            this.thema2.Name = "thema2";
            this.thema2.Size = new System.Drawing.Size(179, 35);
            this.thema2.TabIndex = 2;
            this.thema2.Text = "Переключатели и стабилизаторы";
            this.thema2.UseVisualStyleBackColor = true;
            this.thema2.Click += new System.EventHandler(this.thema_Click);
            // 
            // SecondsLeftLabel
            // 
            this.SecondsLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SecondsLeftLabel.AutoSize = true;
            this.SecondsLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondsLeftLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SecondsLeftLabel.Location = new System.Drawing.Point(6, 433);
            this.SecondsLeftLabel.Name = "SecondsLeftLabel";
            this.SecondsLeftLabel.Size = new System.Drawing.Size(66, 24);
            this.SecondsLeftLabel.TabIndex = 9;
            this.SecondsLeftLabel.Text = "время";
            this.SecondsLeftLabel.Visible = false;
            // 
            // NextQuestionFromCB
            // 
            this.NextQuestionFromCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestionFromCB.Location = new System.Drawing.Point(476, 438);
            this.NextQuestionFromCB.Name = "NextQuestionFromCB";
            this.NextQuestionFromCB.Size = new System.Drawing.Size(123, 31);
            this.NextQuestionFromCB.TabIndex = 7;
            this.NextQuestionFromCB.Text = "Следующий вопрос";
            this.NextQuestionFromCB.UseVisualStyleBackColor = true;
            this.NextQuestionFromCB.Click += new System.EventHandler(this.NextQuestion_Click);
            // 
            // QuestionsPanel
            // 
            this.QuestionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionsPanel.Controls.Add(this.AnswersPanel);
            this.QuestionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionsPanel.Location = new System.Drawing.Point(190, 0);
            this.QuestionsPanel.Name = "QuestionsPanel";
            this.QuestionsPanel.Size = new System.Drawing.Size(610, 498);
            this.QuestionsPanel.TabIndex = 7;
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.Controls.Add(this.EvaluationCriteriaRTB);
            this.AnswersPanel.Controls.Add(this.typesTabControl);
            this.AnswersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswersPanel.Location = new System.Drawing.Point(0, 0);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(610, 498);
            this.AnswersPanel.TabIndex = 1;
            // 
            // EvaluationCriteriaRTB
            // 
            this.EvaluationCriteriaRTB.BackColor = System.Drawing.Color.Gainsboro;
            this.EvaluationCriteriaRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluationCriteriaRTB.Location = new System.Drawing.Point(0, 0);
            this.EvaluationCriteriaRTB.Name = "EvaluationCriteriaRTB";
            this.EvaluationCriteriaRTB.Size = new System.Drawing.Size(610, 498);
            this.EvaluationCriteriaRTB.TabIndex = 10;
            this.EvaluationCriteriaRTB.Text = "";
            // 
            // typesTabControl
            // 
            this.typesTabControl.Controls.Add(this.tbPage);
            this.typesTabControl.Controls.Add(this.rbPage);
            this.typesTabControl.Controls.Add(this.cbPage);
            this.typesTabControl.Controls.Add(this.resultPage);
            this.typesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typesTabControl.Location = new System.Drawing.Point(0, 0);
            this.typesTabControl.Name = "typesTabControl";
            this.typesTabControl.SelectedIndex = 0;
            this.typesTabControl.Size = new System.Drawing.Size(610, 498);
            this.typesTabControl.TabIndex = 11;
            this.typesTabControl.Visible = false;
            // 
            // tbPage
            // 
            this.tbPage.BackColor = System.Drawing.Color.Transparent;
            this.tbPage.Controls.Add(this.QuestionNameLabel);
            this.tbPage.Controls.Add(this.SecondsLeftLabel);
            this.tbPage.Controls.Add(this.exitBox);
            this.tbPage.Controls.Add(this.HidePB);
            this.tbPage.Controls.Add(this.NextQuestionFromTB);
            this.tbPage.Controls.Add(this.answerTextBox);
            this.tbPage.Location = new System.Drawing.Point(4, 22);
            this.tbPage.Name = "tbPage";
            this.tbPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage.Size = new System.Drawing.Size(602, 472);
            this.tbPage.TabIndex = 0;
            // 
            // QuestionNameLabel
            // 
            this.QuestionNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionNameLabel.AutoSize = true;
            this.QuestionNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuestionNameLabel.Location = new System.Drawing.Point(270, 29);
            this.QuestionNameLabel.Name = "QuestionNameLabel";
            this.QuestionNameLabel.Size = new System.Drawing.Size(67, 29);
            this.QuestionNameLabel.TabIndex = 8;
            this.QuestionNameLabel.Text = "adad";
            // 
            // exitBox
            // 
            this.exitBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBox.BackColor = System.Drawing.Color.White;
            this.exitBox.Image = global::MKG.Properties.Resources.ext1;
            this.exitBox.Location = new System.Drawing.Point(580, 3);
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
            this.HidePB.Location = new System.Drawing.Point(555, 3);
            this.HidePB.Name = "HidePB";
            this.HidePB.Size = new System.Drawing.Size(22, 22);
            this.HidePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HidePB.TabIndex = 13;
            this.HidePB.TabStop = false;
            this.HidePB.Click += new System.EventHandler(this.HidePB_Click);
            // 
            // NextQuestionFromTB
            // 
            this.NextQuestionFromTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestionFromTB.Location = new System.Drawing.Point(476, 433);
            this.NextQuestionFromTB.Name = "NextQuestionFromTB";
            this.NextQuestionFromTB.Size = new System.Drawing.Size(123, 31);
            this.NextQuestionFromTB.TabIndex = 8;
            this.NextQuestionFromTB.Text = "Следующий вопрос";
            this.NextQuestionFromTB.UseVisualStyleBackColor = true;
            this.NextQuestionFromTB.Click += new System.EventHandler(this.NextQuestion_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextBox.Location = new System.Drawing.Point(195, 139);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(210, 35);
            this.answerTextBox.TabIndex = 1;
            // 
            // rbPage
            // 
            this.rbPage.BackColor = System.Drawing.Color.Transparent;
            this.rbPage.Controls.Add(this.RadioPanel);
            this.rbPage.Location = new System.Drawing.Point(4, 22);
            this.rbPage.Name = "rbPage";
            this.rbPage.Padding = new System.Windows.Forms.Padding(3);
            this.rbPage.Size = new System.Drawing.Size(602, 472);
            this.rbPage.TabIndex = 1;
            // 
            // RadioPanel
            // 
            this.RadioPanel.Controls.Add(this.pictureBox1);
            this.RadioPanel.Controls.Add(this.pictureBox2);
            this.RadioPanel.Controls.Add(this.NextQuestionFromRadio);
            this.RadioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioPanel.Location = new System.Drawing.Point(3, 3);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(596, 466);
            this.RadioPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::MKG.Properties.Resources.ext1;
            this.pictureBox1.Location = new System.Drawing.Point(574, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::MKG.Properties.Resources.sver;
            this.pictureBox2.Location = new System.Drawing.Point(549, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.HidePB_Click);
            // 
            // NextQuestionFromRadio
            // 
            this.NextQuestionFromRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestionFromRadio.Location = new System.Drawing.Point(470, 432);
            this.NextQuestionFromRadio.Name = "NextQuestionFromRadio";
            this.NextQuestionFromRadio.Size = new System.Drawing.Size(123, 31);
            this.NextQuestionFromRadio.TabIndex = 8;
            this.NextQuestionFromRadio.Text = "Следующий вопрос";
            this.NextQuestionFromRadio.UseVisualStyleBackColor = true;
            this.NextQuestionFromRadio.Click += new System.EventHandler(this.NextQuestion_Click);
            // 
            // cbPage
            // 
            this.cbPage.BackColor = System.Drawing.Color.Transparent;
            this.cbPage.Controls.Add(this.CheckPanel);
            this.cbPage.Location = new System.Drawing.Point(4, 22);
            this.cbPage.Name = "cbPage";
            this.cbPage.Size = new System.Drawing.Size(602, 472);
            this.cbPage.TabIndex = 2;
            // 
            // CheckPanel
            // 
            this.CheckPanel.Controls.Add(this.pictureBox3);
            this.CheckPanel.Controls.Add(this.pictureBox4);
            this.CheckPanel.Controls.Add(this.NextQuestionFromCB);
            this.CheckPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckPanel.Location = new System.Drawing.Point(0, 0);
            this.CheckPanel.Name = "CheckPanel";
            this.CheckPanel.Size = new System.Drawing.Size(602, 472);
            this.CheckPanel.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::MKG.Properties.Resources.ext1;
            this.pictureBox3.Location = new System.Drawing.Point(580, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::MKG.Properties.Resources.sver;
            this.pictureBox4.Location = new System.Drawing.Point(555, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.HidePB_Click);
            // 
            // resultPage
            // 
            this.resultPage.BackColor = System.Drawing.Color.MediumBlue;
            this.resultPage.Controls.Add(this.ResultLabel);
            this.resultPage.Location = new System.Drawing.Point(4, 22);
            this.resultPage.Name = "resultPage";
            this.resultPage.Size = new System.Drawing.Size(602, 472);
            this.resultPage.TabIndex = 3;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ResultLabel.Location = new System.Drawing.Point(101, 112);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(172, 42);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "RESULT";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MKG.Properties.Resources._123312123312;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 498);
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
            this.typesTabControl.ResumeLayout(false);
            this.tbPage.ResumeLayout(false);
            this.tbPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePB)).EndInit();
            this.rbPage.ResumeLayout(false);
            this.RadioPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cbPage.ResumeLayout(false);
            this.CheckPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.resultPage.ResumeLayout(false);
            this.resultPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ThemasPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button theoryButton;
        private System.Windows.Forms.Button thema1;
        private System.Windows.Forms.Button thema3;
        private System.Windows.Forms.Button thema2;
        private System.Windows.Forms.Button NextQuestionFromCB;
        private System.Windows.Forms.Panel QuestionsPanel;
        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.TabControl typesTabControl;
        private System.Windows.Forms.TabPage tbPage;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.TabPage rbPage;
        private System.Windows.Forms.Panel RadioPanel;
        private System.Windows.Forms.TabPage cbPage;
        private System.Windows.Forms.Button NextQuestionFromRadio;
        private System.Windows.Forms.Button NextQuestionFromTB;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.Panel CheckPanel;
        private System.Windows.Forms.TabPage resultPage;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label SecondsLeftLabel;
        private System.Windows.Forms.Button LeaveFromTest;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox HidePB;
        private System.Windows.Forms.Label QuestionNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RichTextBox EvaluationCriteriaRTB;
    }
}

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
            this.ThemasPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.theoryButton = new System.Windows.Forms.Button();
            this.thema4 = new System.Windows.Forms.Button();
            this.thema1 = new System.Windows.Forms.Button();
            this.thema3 = new System.Windows.Forms.Button();
            this.thema2 = new System.Windows.Forms.Button();
            this.QuestionNameLabel = new System.Windows.Forms.Label();
            this.NextQuestionFromCB = new System.Windows.Forms.Button();
            this.QuestionsPanel = new System.Windows.Forms.Panel();
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.typesTabControl = new System.Windows.Forms.TabControl();
            this.tbPage = new System.Windows.Forms.TabPage();
            this.NextQuestionFromTB = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.rbPage = new System.Windows.Forms.TabPage();
            this.NextQuestionFromRadio = new System.Windows.Forms.Button();
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.cbPage = new System.Windows.Forms.TabPage();
            this.CheckPanel = new System.Windows.Forms.Panel();
            this.resultPage = new System.Windows.Forms.TabPage();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ThemasPanel.SuspendLayout();
            this.QuestionsPanel.SuspendLayout();
            this.AnswersPanel.SuspendLayout();
            this.typesTabControl.SuspendLayout();
            this.tbPage.SuspendLayout();
            this.rbPage.SuspendLayout();
            this.cbPage.SuspendLayout();
            this.resultPage.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThemasPanel
            // 
            this.ThemasPanel.BackColor = System.Drawing.Color.Transparent;
            this.ThemasPanel.Controls.Add(this.label1);
            this.ThemasPanel.Controls.Add(this.theoryButton);
            this.ThemasPanel.Controls.Add(this.thema4);
            this.ThemasPanel.Controls.Add(this.thema1);
            this.ThemasPanel.Controls.Add(this.thema3);
            this.ThemasPanel.Controls.Add(this.thema2);
            this.ThemasPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThemasPanel.Location = new System.Drawing.Point(0, 0);
            this.ThemasPanel.Name = "ThemasPanel";
            this.ThemasPanel.Size = new System.Drawing.Size(190, 450);
            this.ThemasPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тестирование";
            // 
            // theoryButton
            // 
            this.theoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.theoryButton.Location = new System.Drawing.Point(8, 411);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(170, 31);
            this.theoryButton.TabIndex = 5;
            this.theoryButton.Text = "Перейти к теории";
            this.theoryButton.UseVisualStyleBackColor = true;
            this.theoryButton.Click += new System.EventHandler(this.theoryButton_Click);
            // 
            // thema4
            // 
            this.thema4.Location = new System.Drawing.Point(8, 176);
            this.thema4.Name = "thema4";
            this.thema4.Size = new System.Drawing.Size(179, 34);
            this.thema4.TabIndex = 4;
            this.thema4.Text = "Стабилизаторы";
            this.thema4.UseVisualStyleBackColor = true;
            this.thema4.Click += new System.EventHandler(this.thema_Click);
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
            // thema2
            // 
            this.thema2.Location = new System.Drawing.Point(8, 96);
            this.thema2.Name = "thema2";
            this.thema2.Size = new System.Drawing.Size(179, 35);
            this.thema2.TabIndex = 2;
            this.thema2.Text = "Переключатели";
            this.thema2.UseVisualStyleBackColor = true;
            this.thema2.Click += new System.EventHandler(this.thema_Click);
            // 
            // QuestionNameLabel
            // 
            this.QuestionNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionNameLabel.AutoSize = true;
            this.QuestionNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QuestionNameLabel.Location = new System.Drawing.Point(271, 21);
            this.QuestionNameLabel.Name = "QuestionNameLabel";
            this.QuestionNameLabel.Size = new System.Drawing.Size(67, 29);
            this.QuestionNameLabel.TabIndex = 8;
            this.QuestionNameLabel.Text = "adad";
            // 
            // NextQuestionFromCB
            // 
            this.NextQuestionFromCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestionFromCB.Location = new System.Drawing.Point(476, 319);
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
            this.QuestionsPanel.Controls.Add(this.TitlePanel);
            this.QuestionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionsPanel.Location = new System.Drawing.Point(190, 0);
            this.QuestionsPanel.Name = "QuestionsPanel";
            this.QuestionsPanel.Size = new System.Drawing.Size(610, 450);
            this.QuestionsPanel.TabIndex = 7;
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.Controls.Add(this.typesTabControl);
            this.AnswersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswersPanel.Location = new System.Drawing.Point(0, 71);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(610, 379);
            this.AnswersPanel.TabIndex = 1;
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
            this.typesTabControl.Size = new System.Drawing.Size(610, 379);
            this.typesTabControl.TabIndex = 11;
            this.typesTabControl.Visible = false;
            // 
            // tbPage
            // 
            this.tbPage.BackColor = System.Drawing.Color.OrangeRed;
            this.tbPage.Controls.Add(this.NextQuestionFromTB);
            this.tbPage.Controls.Add(this.answerTextBox);
            this.tbPage.Location = new System.Drawing.Point(4, 22);
            this.tbPage.Name = "tbPage";
            this.tbPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage.Size = new System.Drawing.Size(602, 353);
            this.tbPage.TabIndex = 0;
            this.tbPage.Text = "tabPage1";
            // 
            // NextQuestionFromTB
            // 
            this.NextQuestionFromTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestionFromTB.Location = new System.Drawing.Point(476, 319);
            this.NextQuestionFromTB.Name = "NextQuestionFromTB";
            this.NextQuestionFromTB.Size = new System.Drawing.Size(123, 31);
            this.NextQuestionFromTB.TabIndex = 8;
            this.NextQuestionFromTB.Text = "Следующий вопрос";
            this.NextQuestionFromTB.UseVisualStyleBackColor = true;
            this.NextQuestionFromTB.Click += new System.EventHandler(this.NextQuestion_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextBox.Location = new System.Drawing.Point(192, 124);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(210, 26);
            this.answerTextBox.TabIndex = 1;
            // 
            // rbPage
            // 
            this.rbPage.BackColor = System.Drawing.Color.Gold;
            this.rbPage.Controls.Add(this.NextQuestionFromRadio);
            this.rbPage.Controls.Add(this.RadioPanel);
            this.rbPage.Location = new System.Drawing.Point(4, 22);
            this.rbPage.Name = "rbPage";
            this.rbPage.Padding = new System.Windows.Forms.Padding(3);
            this.rbPage.Size = new System.Drawing.Size(602, 353);
            this.rbPage.TabIndex = 1;
            this.rbPage.Text = "tabPage2";
            // 
            // NextQuestionFromRadio
            // 
            this.NextQuestionFromRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestionFromRadio.Location = new System.Drawing.Point(473, 316);
            this.NextQuestionFromRadio.Name = "NextQuestionFromRadio";
            this.NextQuestionFromRadio.Size = new System.Drawing.Size(123, 31);
            this.NextQuestionFromRadio.TabIndex = 8;
            this.NextQuestionFromRadio.Text = "Следующий вопрос";
            this.NextQuestionFromRadio.UseVisualStyleBackColor = true;
            this.NextQuestionFromRadio.Click += new System.EventHandler(this.NextQuestion_Click);
            // 
            // RadioPanel
            // 
            this.RadioPanel.Location = new System.Drawing.Point(6, 6);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(585, 304);
            this.RadioPanel.TabIndex = 1;
            // 
            // cbPage
            // 
            this.cbPage.BackColor = System.Drawing.Color.Lime;
            this.cbPage.Controls.Add(this.CheckPanel);
            this.cbPage.Controls.Add(this.NextQuestionFromCB);
            this.cbPage.Location = new System.Drawing.Point(4, 22);
            this.cbPage.Name = "cbPage";
            this.cbPage.Size = new System.Drawing.Size(602, 353);
            this.cbPage.TabIndex = 2;
            this.cbPage.Text = "tabPage3";
            // 
            // CheckPanel
            // 
            this.CheckPanel.Location = new System.Drawing.Point(12, 3);
            this.CheckPanel.Name = "CheckPanel";
            this.CheckPanel.Size = new System.Drawing.Size(582, 310);
            this.CheckPanel.TabIndex = 8;
            // 
            // resultPage
            // 
            this.resultPage.BackColor = System.Drawing.Color.MediumBlue;
            this.resultPage.Controls.Add(this.ResultLabel);
            this.resultPage.Location = new System.Drawing.Point(4, 22);
            this.resultPage.Name = "resultPage";
            this.resultPage.Size = new System.Drawing.Size(602, 353);
            this.resultPage.TabIndex = 3;
            this.resultPage.Text = "результаты";
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.ReadyButton);
            this.TitlePanel.Controls.Add(this.QuestionNameLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(610, 71);
            this.TitlePanel.TabIndex = 0;
            // 
            // ReadyButton
            // 
            this.ReadyButton.Location = new System.Drawing.Point(516, 3);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(64, 35);
            this.ReadyButton.TabIndex = 8;
            this.ReadyButton.Text = "Начать тестирование";
            this.ReadyButton.UseVisualStyleBackColor = true;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ResultLabel.Location = new System.Drawing.Point(101, 112);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(429, 108);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "RESULT";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MKG.Properties.Resources._123312123312;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuestionsPanel);
            this.Controls.Add(this.ThemasPanel);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ThemasPanel.ResumeLayout(false);
            this.ThemasPanel.PerformLayout();
            this.QuestionsPanel.ResumeLayout(false);
            this.AnswersPanel.ResumeLayout(false);
            this.typesTabControl.ResumeLayout(false);
            this.tbPage.ResumeLayout(false);
            this.tbPage.PerformLayout();
            this.rbPage.ResumeLayout(false);
            this.cbPage.ResumeLayout(false);
            this.resultPage.ResumeLayout(false);
            this.resultPage.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ThemasPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button theoryButton;
        private System.Windows.Forms.Button thema4;
        private System.Windows.Forms.Button thema1;
        private System.Windows.Forms.Button thema3;
        private System.Windows.Forms.Button thema2;
        private System.Windows.Forms.Label QuestionNameLabel;
        private System.Windows.Forms.Button NextQuestionFromCB;
        private System.Windows.Forms.Panel QuestionsPanel;
        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Panel TitlePanel;
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
    }
}
namespace MedAkinator
{
    partial class Form1
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
            this.lstBoxQuestions = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.txtBoxQuestionFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditAnswer = new System.Windows.Forms.Button();
            this.btnRemoveAnswer = new System.Windows.Forms.Button();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.txtBoxAnswerFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxAnswers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxCurrQuestion = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnCloserYesThanNo = new System.Windows.Forms.Button();
            this.btnCloserNoThanYes = new System.Windows.Forms.Button();
            this.btnDoesNotMakeSence = new System.Windows.Forms.Button();
            this.btnMarkAsAnswer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxQuestions
            // 
            this.lstBoxQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxQuestions.FormattingEnabled = true;
            this.lstBoxQuestions.Location = new System.Drawing.Point(11, 17);
            this.lstBoxQuestions.Name = "lstBoxQuestions";
            this.lstBoxQuestions.Size = new System.Drawing.Size(182, 277);
            this.lstBoxQuestions.TabIndex = 0;
            this.lstBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.lstBoxQuestions_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnEditQuestion);
            this.groupBox1.Controls.Add(this.btnRemoveQuestion);
            this.groupBox1.Controls.Add(this.btnAddQuestion);
            this.groupBox1.Controls.Add(this.txtBoxQuestionFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstBoxQuestions);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QuestionsAll";
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditQuestion.Location = new System.Drawing.Point(45, 323);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(36, 23);
            this.btnEditQuestion.TabIndex = 5;
            this.btnEditQuestion.Text = "Edit";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveQuestion.Location = new System.Drawing.Point(87, 323);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(32, 23);
            this.btnRemoveQuestion.TabIndex = 4;
            this.btnRemoveQuestion.Text = "-";
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddQuestion.Location = new System.Drawing.Point(7, 323);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(32, 23);
            this.btnAddQuestion.TabIndex = 3;
            this.btnAddQuestion.Text = "+";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // txtBoxQuestionFilter
            // 
            this.txtBoxQuestionFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxQuestionFilter.Location = new System.Drawing.Point(45, 297);
            this.txtBoxQuestionFilter.Name = "txtBoxQuestionFilter";
            this.txtBoxQuestionFilter.Size = new System.Drawing.Size(148, 20);
            this.txtBoxQuestionFilter.TabIndex = 2;
            this.txtBoxQuestionFilter.TextChanged += new System.EventHandler(this.txtBoxQuestionFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnEditAnswer);
            this.groupBox2.Controls.Add(this.btnRemoveAnswer);
            this.groupBox2.Controls.Add(this.btnAddAnswer);
            this.groupBox2.Controls.Add(this.txtBoxAnswerFilter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lstBoxAnswers);
            this.groupBox2.Location = new System.Drawing.Point(206, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 354);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AnswersAll";
            // 
            // btnEditAnswer
            // 
            this.btnEditAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditAnswer.Location = new System.Drawing.Point(80, 323);
            this.btnEditAnswer.Name = "btnEditAnswer";
            this.btnEditAnswer.Size = new System.Drawing.Size(36, 23);
            this.btnEditAnswer.TabIndex = 6;
            this.btnEditAnswer.Text = "Edit";
            this.btnEditAnswer.UseVisualStyleBackColor = true;
            this.btnEditAnswer.Click += new System.EventHandler(this.btnEditAnswer_Click);
            // 
            // btnRemoveAnswer
            // 
            this.btnRemoveAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveAnswer.Location = new System.Drawing.Point(42, 323);
            this.btnRemoveAnswer.Name = "btnRemoveAnswer";
            this.btnRemoveAnswer.Size = new System.Drawing.Size(32, 23);
            this.btnRemoveAnswer.TabIndex = 4;
            this.btnRemoveAnswer.Text = "-";
            this.btnRemoveAnswer.UseVisualStyleBackColor = true;
            this.btnRemoveAnswer.Click += new System.EventHandler(this.btnRemoveAnswer_Click);
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAnswer.Location = new System.Drawing.Point(4, 323);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(32, 23);
            this.btnAddAnswer.TabIndex = 3;
            this.btnAddAnswer.Text = "+";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // txtBoxAnswerFilter
            // 
            this.txtBoxAnswerFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAnswerFilter.Location = new System.Drawing.Point(40, 297);
            this.txtBoxAnswerFilter.Name = "txtBoxAnswerFilter";
            this.txtBoxAnswerFilter.Size = new System.Drawing.Size(161, 20);
            this.txtBoxAnswerFilter.TabIndex = 2;
            this.txtBoxAnswerFilter.TextChanged += new System.EventHandler(this.txtBoxAnswerFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter:";
            // 
            // lstBoxAnswers
            // 
            this.lstBoxAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxAnswers.FormattingEnabled = true;
            this.lstBoxAnswers.Location = new System.Drawing.Point(6, 17);
            this.lstBoxAnswers.Name = "lstBoxAnswers";
            this.lstBoxAnswers.Size = new System.Drawing.Size(195, 277);
            this.lstBoxAnswers.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User:";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(459, 6);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.ReadOnly = true;
            this.txtBoxUser.Size = new System.Drawing.Size(164, 20);
            this.txtBoxUser.TabIndex = 7;
            this.txtBoxUser.Text = "Admin";
            // 
            // txtBoxCurrQuestion
            // 
            this.txtBoxCurrQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCurrQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxCurrQuestion.Location = new System.Drawing.Point(424, 32);
            this.txtBoxCurrQuestion.Multiline = true;
            this.txtBoxCurrQuestion.Name = "txtBoxCurrQuestion";
            this.txtBoxCurrQuestion.ReadOnly = true;
            this.txtBoxCurrQuestion.Size = new System.Drawing.Size(369, 122);
            this.txtBoxCurrQuestion.TabIndex = 8;
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.Location = new System.Drawing.Point(664, 160);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(129, 23);
            this.btnYes.TabIndex = 9;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.Location = new System.Drawing.Point(661, 189);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(132, 23);
            this.btnNo.TabIndex = 10;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnCloserYesThanNo
            // 
            this.btnCloserYesThanNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloserYesThanNo.Location = new System.Drawing.Point(661, 218);
            this.btnCloserYesThanNo.Name = "btnCloserYesThanNo";
            this.btnCloserYesThanNo.Size = new System.Drawing.Size(132, 23);
            this.btnCloserYesThanNo.TabIndex = 11;
            this.btnCloserYesThanNo.Text = "Closer Yes Than No";
            this.btnCloserYesThanNo.UseVisualStyleBackColor = true;
            this.btnCloserYesThanNo.Click += new System.EventHandler(this.btnCloserYesThanNo_Click);
            // 
            // btnCloserNoThanYes
            // 
            this.btnCloserNoThanYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloserNoThanYes.Location = new System.Drawing.Point(661, 247);
            this.btnCloserNoThanYes.Name = "btnCloserNoThanYes";
            this.btnCloserNoThanYes.Size = new System.Drawing.Size(132, 23);
            this.btnCloserNoThanYes.TabIndex = 12;
            this.btnCloserNoThanYes.Text = "Closer No than Yes";
            this.btnCloserNoThanYes.UseVisualStyleBackColor = true;
            this.btnCloserNoThanYes.Click += new System.EventHandler(this.btnCloserNoThanYes_Click);
            // 
            // btnDoesNotMakeSence
            // 
            this.btnDoesNotMakeSence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoesNotMakeSence.Location = new System.Drawing.Point(661, 276);
            this.btnDoesNotMakeSence.Name = "btnDoesNotMakeSence";
            this.btnDoesNotMakeSence.Size = new System.Drawing.Size(132, 23);
            this.btnDoesNotMakeSence.TabIndex = 13;
            this.btnDoesNotMakeSence.Text = "Does Not Make Sence";
            this.btnDoesNotMakeSence.UseVisualStyleBackColor = true;
            this.btnDoesNotMakeSence.Click += new System.EventHandler(this.btnDoesNotMakeSence_Click);
            // 
            // btnMarkAsAnswer
            // 
            this.btnMarkAsAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkAsAnswer.Location = new System.Drawing.Point(600, 324);
            this.btnMarkAsAnswer.Name = "btnMarkAsAnswer";
            this.btnMarkAsAnswer.Size = new System.Drawing.Size(193, 23);
            this.btnMarkAsAnswer.TabIndex = 14;
            this.btnMarkAsAnswer.Text = "Edit reactions / Mark as final answer";
            this.btnMarkAsAnswer.UseVisualStyleBackColor = true;
            this.btnMarkAsAnswer.Click += new System.EventHandler(this.btnMarkAsAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 359);
            this.Controls.Add(this.btnMarkAsAnswer);
            this.Controls.Add(this.btnDoesNotMakeSence);
            this.Controls.Add(this.btnCloserNoThanYes);
            this.Controls.Add(this.btnCloserYesThanNo);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtBoxCurrQuestion);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxQuestions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TextBox txtBoxQuestionFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditAnswer;
        private System.Windows.Forms.Button btnRemoveAnswer;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.TextBox txtBoxAnswerFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxAnswers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxCurrQuestion;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnCloserYesThanNo;
        private System.Windows.Forms.Button btnCloserNoThanYes;
        private System.Windows.Forms.Button btnDoesNotMakeSence;
        private System.Windows.Forms.Button btnMarkAsAnswer;
    }
}


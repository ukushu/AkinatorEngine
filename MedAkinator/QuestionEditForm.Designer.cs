namespace MedAkinator
{
    partial class QuestionEditForm
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
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cBoxHiddenFromUI = new System.Windows.Forms.CheckBox();
            this.cBoxShownOnlyForDoctors = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBoxQuestion
            // 
            this.txtBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxQuestion.Location = new System.Drawing.Point(12, 12);
            this.txtBoxQuestion.Multiline = true;
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            this.txtBoxQuestion.Size = new System.Drawing.Size(424, 205);
            this.txtBoxQuestion.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(362, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(281, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cBoxHiddenFromUI
            // 
            this.cBoxHiddenFromUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxHiddenFromUI.AutoSize = true;
            this.cBoxHiddenFromUI.Location = new System.Drawing.Point(13, 224);
            this.cBoxHiddenFromUI.Name = "cBoxHiddenFromUI";
            this.cBoxHiddenFromUI.Size = new System.Drawing.Size(100, 17);
            this.cBoxHiddenFromUI.TabIndex = 3;
            this.cBoxHiddenFromUI.Text = "Hidden From UI";
            this.cBoxHiddenFromUI.UseVisualStyleBackColor = true;
            // 
            // cBoxShownOnlyForDoctors
            // 
            this.cBoxShownOnlyForDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxShownOnlyForDoctors.AutoSize = true;
            this.cBoxShownOnlyForDoctors.Location = new System.Drawing.Point(119, 223);
            this.cBoxShownOnlyForDoctors.Name = "cBoxShownOnlyForDoctors";
            this.cBoxShownOnlyForDoctors.Size = new System.Drawing.Size(141, 17);
            this.cBoxShownOnlyForDoctors.TabIndex = 4;
            this.cBoxShownOnlyForDoctors.Text = "Shown Only For Doctors";
            this.cBoxShownOnlyForDoctors.UseVisualStyleBackColor = true;
            // 
            // QuestionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 275);
            this.Controls.Add(this.cBoxShownOnlyForDoctors);
            this.Controls.Add(this.cBoxHiddenFromUI);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxQuestion);
            this.Name = "QuestionEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionEditForm";
            this.Load += new System.EventHandler(this.QuestionEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxQuestion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cBoxHiddenFromUI;
        private System.Windows.Forms.CheckBox cBoxShownOnlyForDoctors;
    }
}
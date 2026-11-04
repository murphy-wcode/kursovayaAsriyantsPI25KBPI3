namespace kursovaya20
{
    partial class FormSchedule
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstAll = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(68, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Все записи:";
            // 
            // lstAll
            // 
            this.lstAll.FormattingEnabled = true;
            this.lstAll.ItemHeight = 16;
            this.lstAll.Location = new System.Drawing.Point(194, 65);
            this.lstAll.Name = "lstAll";
            this.lstAll.Size = new System.Drawing.Size(490, 244);
            this.lstAll.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(93, 352);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(194, 50);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Подтвердить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(524, 352);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(194, 50);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Отклонить";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lstAll);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormSchedule";
            this.Text = "Расписание врача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstAll;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReject;
    }
}
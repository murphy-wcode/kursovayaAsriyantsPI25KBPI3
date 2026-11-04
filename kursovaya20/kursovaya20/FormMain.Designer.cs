namespace kursovaya20
{
    partial class FormMain
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(225, 69);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(133, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать!";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnProfile.Location = new System.Drawing.Point(263, 118);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(193, 38);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Профиль";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSchedule.Location = new System.Drawing.Point(263, 309);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(193, 38);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Расписание врача";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Visible = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHistory.Location = new System.Drawing.Point(263, 244);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(193, 38);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "История";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAppointment.Location = new System.Drawing.Point(263, 180);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(193, 38);
            this.btnAppointment.TabIndex = 4;
            this.btnAppointment.Text = "Записаться на приём";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FormMain";
            this.Text = "Главное окно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnAppointment;
    }
}
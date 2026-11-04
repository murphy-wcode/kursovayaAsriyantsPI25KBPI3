namespace kursovaya20
{
    partial class FormRoleSelect
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(343, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "VetCare";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(343, 150);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(57, 16);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Кто вы?";
            // 
            // btnOwner
            // 
            this.btnOwner.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOwner.Location = new System.Drawing.Point(180, 208);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(177, 96);
            this.btnOwner.TabIndex = 2;
            this.btnOwner.Text = "Владелец животного";
            this.btnOwner.UseVisualStyleBackColor = false;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStaff.Location = new System.Drawing.Point(411, 208);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(177, 96);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Сотрудник клиники";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // FormRoleSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormRoleSelect";
            this.Text = "Выбор роли";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnStaff;
    }
}


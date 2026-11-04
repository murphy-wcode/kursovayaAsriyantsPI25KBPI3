namespace kursovaya20
{
    partial class FormProfile
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPets = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstPets = new System.Windows.Forms.ListBox();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(343, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Профиль";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(183, 70);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(38, 16);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "ФИО";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(183, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(136, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Электронная почта";
            // 
            // lblPets
            // 
            this.lblPets.AutoSize = true;
            this.lblPets.Location = new System.Drawing.Point(183, 251);
            this.lblPets.Name = "lblPets";
            this.lblPets.Size = new System.Drawing.Size(97, 16);
            this.lblPets.TabIndex = 3;
            this.lblPets.Text = "Мои питомцы:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(346, 73);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(250, 22);
            this.txtFullName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(346, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(293, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 41);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstPets
            // 
            this.lstPets.FormattingEnabled = true;
            this.lstPets.ItemHeight = 16;
            this.lstPets.Location = new System.Drawing.Point(346, 251);
            this.lstPets.Name = "lstPets";
            this.lstPets.Size = new System.Drawing.Size(250, 100);
            this.lstPets.TabIndex = 7;
            // 
            // btnAddPet
            // 
            this.btnAddPet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddPet.Location = new System.Drawing.Point(293, 377);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(151, 37);
            this.btnAddPet.TabIndex = 8;
            this.btnAddPet.Text = "Добавить питомца";
            this.btnAddPet.UseVisualStyleBackColor = false;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.lstPets);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPets);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormProfile";
            this.Text = "Профиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPets;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstPets;
        private System.Windows.Forms.Button btnAddPet;
    }
}
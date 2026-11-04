namespace kursovaya20
{
    partial class FormAppointment
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
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbPet = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(274, 71);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(43, 16);
            this.lblDoctor.TabIndex = 0;
            this.lblDoctor.Text = "Врач:";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Location = new System.Drawing.Point(274, 129);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(68, 16);
            this.lblPet.TabIndex = 1;
            this.lblPet.Text = "Питомец:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(174, 200);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(60, 16);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Начало:";
            this.lblStart.VisibleChanged += new System.EventHandler(this.lblStart_VisibleChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(445, 200);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(50, 16);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "Конец:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(333, 250);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 4;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(362, 68);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(179, 24);
            this.cmbDoctor.TabIndex = 5;
            // 
            // cmbPet
            // 
            this.cmbPet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPet.FormattingEnabled = true;
            this.cmbPet.Location = new System.Drawing.Point(362, 121);
            this.cmbPet.Name = "cmbPet";
            this.cmbPet.Size = new System.Drawing.Size(179, 24);
            this.cmbPet.TabIndex = 6;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(240, 195);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(169, 22);
            this.dtStart.TabIndex = 7;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(501, 194);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(169, 22);
            this.dtEnd.TabIndex = 8;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBook.Location = new System.Drawing.Point(354, 278);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(141, 48);
            this.btnBook.TabIndex = 9;
            this.btnBook.Text = "Записаться";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // FormAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.cmbPet);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblPet);
            this.Controls.Add(this.lblDoctor);
            this.Name = "FormAppointment";
            this.Text = "Запись на приём";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbPet;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnBook;
    }
}
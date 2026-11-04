using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kursovaya20
{
    public partial class FormMain : Form
    {
        private string _role;

        public FormMain(string role)
        {
            InitializeComponent();
            _role = role;

            lblWelcome.Text = $"Добро пожаловать, {DataStore.CurrentUser.FullName}!";

            if (_role == "staff")
            {
                btnSchedule.Visible = true;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var form = new FormProfile();
            form.ShowDialog();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            var form = new FormAppointment();
            form.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var form = new FormHistory();
            form.ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            var form = new FormSchedule();
            form.ShowDialog();
        }
    }
}
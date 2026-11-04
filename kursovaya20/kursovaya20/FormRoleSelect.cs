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
    public partial class FormRoleSelect : Form
    {
        public FormRoleSelect()
        {
            InitializeComponent();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            var loginForm = new FormLogin("owner");
            loginForm.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            var loginForm = new FormLogin("staff");
            loginForm.Show();
            this.Hide();
        }
    }
}

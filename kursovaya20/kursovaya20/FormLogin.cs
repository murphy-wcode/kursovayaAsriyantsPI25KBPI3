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
    public partial class FormLogin : Form
    {
        private string _role;

        public FormLogin(string role)
        {
            InitializeComponent();
            _role = role;
            lblTitle.Text = role == "owner" ? "VetCare для владельцев" : "VetCare для сотрудников";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = DataStore.Users.Find(u => u.Login == txtLogin.Text && u.Password == txtPassword.Text && u.Role == _role);

            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataStore.CurrentUser = user;
            OpenMain();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var form = new FormRegister(_role);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Регистрация успешна! Теперь войдите.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenMain()
        {
            var form = new FormMain(_role);
            form.Show();
            this.Hide();
        }
    }
}
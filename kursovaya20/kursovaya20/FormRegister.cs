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
    public partial class FormRegister : Form
    {
        private string _role;

        public FormRegister(string role)
        {
            InitializeComponent();
            _role = role;

            if (_role == "owner") lblTitle.Text = "Регистрация владельца";
            else lblTitle.Text = "Регистрация сотрудника";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Пожалуйста, заполните логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DataStore.LoginExists(txtLogin.Text))
            {
                MessageBox.Show("Этот логин уже занят. Придумайте другой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User
            {
                Login = txtLogin.Text,
                Password = txtPassword.Text,
                Role = _role,
                FullName = txtFullName.Text,
                Email = txtEmail.Text
            };
            DataStore.Users.Add(newUser);

            MessageBox.Show("Регистрация успешна! Теперь вы можете войти.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

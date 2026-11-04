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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txtFullName.Text = DataStore.CurrentUser.FullName;
            txtEmail.Text = DataStore.CurrentUser.Email;

            if (DataStore.CurrentUser.Role == "staff")
            {
                lblPets.Visible = false;
                lstPets.Visible = false;
                btnAddPet.Visible = false;
            }
            else
            {
                LoadPets(); 
            }
        }

        private void LoadPets()
        {
            lstPets.Items.Clear();
            var myPets = DataStore.Pets.Where(p => p.OwnerLogin == DataStore.CurrentUser.Login).ToList();

            foreach (var pet in myPets)
            {
                lstPets.Items.Add($"{pet.Name} ({pet.Species}, {pet.Breed})");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataStore.CurrentUser.FullName = txtFullName.Text;
            DataStore.CurrentUser.Email = txtEmail.Text;
            MessageBox.Show("Данные профиля обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            Form prompt = new Form()
            {
                Width = 350,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Новый питомец",
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false
            };

            Label lblName = new Label() { Left = 20, Top = 20, Text = "Имя питомца:", Width = 100 };
            TextBox txtName = new TextBox() { Left = 130, Top = 15, Width = 180 };

            Label lblSpecies = new Label() { Left = 20, Top = 60, Text = "Вид (кошка/собака):", Width = 110 };
            TextBox txtSpecies = new TextBox() { Left = 130, Top = 55, Width = 180 };

            Label lblBreed = new Label() { Left = 20, Top = 100, Text = "Порода:", Width = 100 };
            TextBox txtBreed = new TextBox() { Left = 130, Top = 95, Width = 180 };

            Button btnOk = new Button() { Text = "Добавить", Left = 130, Top = 150, Width = 100, DialogResult = DialogResult.OK };

            prompt.Controls.Add(lblName); prompt.Controls.Add(txtName);
            prompt.Controls.Add(lblSpecies); prompt.Controls.Add(txtSpecies);
            prompt.Controls.Add(lblBreed); prompt.Controls.Add(txtBreed);
            prompt.Controls.Add(btnOk);

            if (prompt.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                DataStore.Pets.Add(new Pet
                {
                    Name = txtName.Text,
                    Species = txtSpecies.Text,
                    Breed = txtBreed.Text,
                    OwnerLogin = DataStore.CurrentUser.Login
                });

                LoadPets(); 
                MessageBox.Show("Питомец успешно добавлен!");
            }
        }
    }
}

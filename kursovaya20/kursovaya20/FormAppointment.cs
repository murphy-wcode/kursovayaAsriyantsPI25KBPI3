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
    public partial class FormAppointment : Form
    {
        private const decimal PricePerHour = 1000m;

        public FormAppointment()
        {
            InitializeComponent();

            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "dd.MM.yyyy HH:mm";
            dtStart.ShowUpDown = true;

            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            dtEnd.ShowUpDown = true;

            LoadDoctors();
            LoadPets();

            UpdatePrice();
        }

        private void LoadDoctors()
        {
            cmbDoctor.Items.Clear();
            foreach (var doc in DataStore.Doctors)
            {
                cmbDoctor.Items.Add($"{doc.FullName} ({doc.Specialization})");
            }
            if (cmbDoctor.Items.Count > 0) cmbDoctor.SelectedIndex = 0;
        }

        private void LoadPets()
        {
            cmbPet.Items.Clear();
            var myPets = DataStore.Pets.Where(p => p.OwnerLogin == DataStore.CurrentUser.Login).ToList();

            foreach (var pet in myPets)
            {
                cmbPet.Items.Add(pet.Name);
            }
            if (cmbPet.Items.Count > 0) cmbPet.SelectedIndex = 0;
            else MessageBox.Show("У вас нет питомцев. Сначала добавьте их в профиле.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdatePrice()
        {
            var start = dtStart.Value;
            var end = dtEnd.Value;

            if (end > start)
            {
                var totalMinutes = (end - start).TotalMinutes;
                var hours = (decimal)totalMinutes / 60m;
                var price = hours * PricePerHour;

                lblPrice.Text = $"Стоимость: {Math.Round(price)} руб.";
            }
            else
            {
                lblPrice.Text = "Стоимость: 0 руб.";
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbPet.SelectedItem == null)
            {
                MessageBox.Show("Выберите питомца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var start = dtStart.Value;
            var end = dtEnd.Value;

            if (end <= start)
            {
                MessageBox.Show("Время окончания должно быть позже начала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var doctorString = cmbDoctor.SelectedItem.ToString();
            var doctorName = doctorString.Substring(0, doctorString.IndexOf('(')).Trim();

            bool isBusy = DataStore.Appointments.Any(a =>
                a.DoctorName == doctorName &&
                a.Status != "Отменена" &&
                a.DateStart < end && a.DateEnd > start);

            if (isBusy)
            {
                MessageBox.Show("У этого врача уже есть запись на выбранное время. Выберите другое.", "Занято", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var totalMinutes = (end - start).TotalMinutes;
            var hours = (decimal)totalMinutes / 60m;
            var price = Math.Round(hours * PricePerHour); 

            DataStore.Appointments.Add(new Appointment
            {
                OwnerLogin = DataStore.CurrentUser.Login,
                PetName = cmbPet.SelectedItem.ToString(),
                DoctorName = doctorName,
                DateStart = start,
                DateEnd = end,
                Price = price,
                Status = "Запланирована" 
            });

            MessageBox.Show($"Запись создана!\nСтоимость: {price} руб.\nВрач: {doctorName}\nОжидайте подтверждения.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); 
        }

        private void lblStart_VisibleChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }
    }
}
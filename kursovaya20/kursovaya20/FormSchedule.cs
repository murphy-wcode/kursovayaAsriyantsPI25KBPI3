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
    public partial class FormSchedule : Form
    {
        public FormSchedule()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            lstAll.Items.Clear();

            var allApps = DataStore.Appointments
                .OrderBy(a => a.DateStart)
                .ToList();

            if (allApps.Count == 0)
            {
                lstAll.Items.Add("Записей пока нет.");
                return;
            }

            foreach (var app in allApps)
            {
                string line = $"{app.DateStart:dd.MM HH:mm} | Питомец: {app.PetName} | Владелец: {app.OwnerLogin} | Врач: {app.DoctorName} | [{app.Status}]";
                lstAll.Items.Add(line);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lstAll.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите запись из списка.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var allApps = DataStore.Appointments.OrderBy(a => a.DateStart).ToList();
            var selectedApp = allApps[lstAll.SelectedIndex];

            if (selectedApp.Status == "Отменена")
            {
                MessageBox.Show("Нельзя подтвердить отмененную запись.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedApp.Status = "Подтверждена";
            MessageBox.Show("Запись подтверждена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshList();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (lstAll.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите запись из списка.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var allApps = DataStore.Appointments.OrderBy(a => a.DateStart).ToList();
            var selectedApp = allApps[lstAll.SelectedIndex];

            selectedApp.Status = "Отменена";
            MessageBox.Show("Запись отклонена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshList();
        }
    }
}
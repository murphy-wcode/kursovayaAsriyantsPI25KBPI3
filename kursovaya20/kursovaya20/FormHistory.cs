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
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            lstHistory.Items.Clear();

            var myAppointments = DataStore.Appointments
                .Where(a => a.OwnerLogin == DataStore.CurrentUser.Login)
                .OrderByDescending(a => a.DateStart)
                .ToList();

            if (myAppointments.Count == 0)
            {
                lstHistory.Items.Add("У вас пока нет записей.");
                return;
            }

            foreach (var app in myAppointments)
            {
                string line = $"{app.DateStart:dd.MM HH:mm}-{app.DateEnd:HH:mm} | " +
                              $"Питомец: {app.PetName} | " +
                              $"Врач: {app.DoctorName} | " +
                              $"{app.Price} руб. | " +
                              $"[{app.Status}]";
                lstHistory.Items.Add(line);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lstHistory.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите запись из списка для отмены.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var myAppointments = DataStore.Appointments
                .Where(a => a.OwnerLogin == DataStore.CurrentUser.Login)
                .OrderByDescending(a => a.DateStart)
                .ToList();

            var selectedApp = myAppointments[lstHistory.SelectedIndex];

            if (selectedApp.Status == "Отменена")
            {
                MessageBox.Show("Эта запись уже отменена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (selectedApp.Status == "Подтверждена")
            {

            }

            selectedApp.Status = "Отменена";

            MessageBox.Show("Запись успешно отменена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshList(); 
        }
    }
}

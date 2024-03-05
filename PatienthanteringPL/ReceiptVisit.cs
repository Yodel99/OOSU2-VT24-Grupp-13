using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatienthanteringELNy;

namespace PatienthanteringPL
{
    public partial class ReceiptVisit : Form
    {
        User ActiveUser { get; }
        public ReceiptVisit(DoctorAppointment doctorAppointment)
        {
            InitializeComponent();
            ShowReceipt(doctorAppointment);
        }
        private void ShowReceipt(DoctorAppointment doctorAppointment)
        {
            RefreshDatagridViewVisit(doctorAppointment);
        }
        private void RefreshDatagridViewVisit(DoctorAppointment appointment)
        {
            
            List<DoctorAppointment> doctorAppointments = new List<DoctorAppointment>();
            doctorAppointments.Add(appointment);

            var dataSource = doctorAppointments.Select(appointments => new
            {
                Datum = appointments.Date,
                BesökNr = appointments.VisitNr,
                PatientNummer = appointments.Patient.PatientNr,
                Patient = appointments.PatientFNamn,
                AnstallningsNr = appointments.ResponsibleNurse.StaffNr,
                Läkare = appointments.ResponsibleNurse.FName
            }).ToList();

            dataGridViewKvittens.DataSource = dataSource;

        }
            private void buttonManageVisits_Click(object sender, EventArgs e)
        {
            ManageVisits manageVisits = new ManageVisits(ActiveUser);
            manageVisits.Show();
            this.Close();
        }
    }
}

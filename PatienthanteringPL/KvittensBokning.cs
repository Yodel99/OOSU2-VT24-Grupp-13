using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatienthanteringEL;

namespace PatienthanteringPL
{
    public partial class KvittensBokning : Form
    {
        public DoctorAppointment LakarBesok { get; }
        public KvittensBokning(DoctorAppointment lakarBesok)
        {
            InitializeComponent();
            LakarBesok = lakarBesok;
            VisaKvittens(lakarBesok);
        }
        private void VisaKvittens(DoctorAppointment lakarBesok)
        {
            RefreshDatagridViewBesok(lakarBesok);
        }
        private void RefreshDatagridViewBesok(DoctorAppointment appointment)
        {
            
            List<DoctorAppointment> doctorAppointments = new List<DoctorAppointment>();
            doctorAppointments.Add(appointment);

            // Skapa en lista med anpassade objekt som innehåller information från alla tre objekt
            var dataSource = doctorAppointments.Select(appointments => new
            {
                Datum = appointments.Datum,
                BesökNr = appointments.VisitNr,
                PatientNummer = appointments.Patient.PatientNr,
                Patient = appointments.PatientFNamn,
                AnstallningsNr = appointments.AnsvarigLakare.StaffNr,
                Läkare = appointments.AnsvarigLakare.FName
            }).ToList();

            // Ställ in DataGridView för att använda vår anpassade datakälla
            dataGridViewKvittens.DataSource = dataSource;

        }
            private void button2_Click(object sender, EventArgs e)
        {
            HanteraBesok hanteraBesok = new HanteraBesok();
            hanteraBesok.Show();
            this.Close();
        }
    }
}

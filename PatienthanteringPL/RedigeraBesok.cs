using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatienthanteringAL;
using System.Diagnostics;

namespace PatienthanteringPL
{
    public partial class RedigeraBesok : Form
    {
        HamtaListaController hamtaListaController = new HamtaListaController();
        ManageVisitController manageVisitController = new ManageVisitController();
        User AktivAnvandare { get; set; }
        public RedigeraBesok(User user)
        {
            InitializeComponent();
            ListaBesok();
            AktivAnvandare = user;
        }
        private void ListaBesok()
        {
            IList<DoctorAppointment> doctorAppointment = hamtaListaController.ListVisits();
            RefreshDatagridViewBesok(doctorAppointment);
        }
        private void RefreshDatagridViewBesok(IList<DoctorAppointment> lakarBesok)
        {
            List<object> lakarBesok1 = new List<object>();

            foreach (DoctorAppointment besok in lakarBesok)
            {
                lakarBesok1.Add(new { Datum = besok.Datum, BesökNr = besok.VisitNr, Syfte = besok.Syfte, Patient = besok.PatientFNamn, Läkare = besok.LakareFnamn });
            }

            dataGridViewBefintligaBesok.DataSource = lakarBesok1;
        }
        

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            string besokNr = textBoxBesokNr.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(besokNr))
            {
                MessageBox.Show("Vänligen ange ett besöksnummer.");
                return;
            }

            DoctorAppointment doctorAppointment = manageVisitController.GetVisit(besokNr);
            if (doctorAppointment == null)
            {
                MessageBox.Show("Ingen bokning hittades med det angivna besöksnumret.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Är du säker på att du vill ta bort bokningen?", "Bekräfta borttagning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    manageVisitController.RemoveAppointment(besokNr);
                    MessageBox.Show("Bokning borttagen.");
                    HanteraBesok hanteraBesok = new HanteraBesok(AktivAnvandare);
                    hanteraBesok.Show();
                    this.Close();
                }
            }
        }
        

        private void buttonRedigeraTid_Click(object sender, EventArgs e)
        {
            string besokNr = textBoxBesokNr.Text.ToUpper();

            
            if (string.IsNullOrWhiteSpace(besokNr))
            {
                MessageBox.Show("Vänligen ange ett besöksnummer.");
                return;
            }
            DoctorAppointment doctorAppointment = manageVisitController.GetVisit(besokNr);
            if (doctorAppointment == null)
            {
                MessageBox.Show("Inget besök hittades med det angivna besöksnumret.");
            }
            else
            {
                
                AndraTidBesok andraTidBesok = new AndraTidBesok(doctorAppointment);
                andraTidBesok.Show();
                this.Close();
            }
            
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            HanteraBesok hanterabesok = new HanteraBesok(AktivAnvandare);
            hanterabesok.Show();
            this.Close();
        }
    }
}

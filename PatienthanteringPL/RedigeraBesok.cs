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
        Patienthantering patienthantering = new Patienthantering();
        ManageVisitController manageVisitController = new ManageVisitController();
        public RedigeraBesok()
        {
            InitializeComponent();
            ListaBesok();
        }
        private void ListaBesok()
        {
            IList<DoctorAppointment> doctorAppointment = manageVisitController.ListVisits();
            RefreshDatagridViewBesok(doctorAppointment);
        }
        private void RefreshDatagridViewBesok(IList<DoctorAppointment> lakarBesok)
        {
            List<object> lakarBesok1 = new List<object>();

            foreach (DoctorAppointment besok in lakarBesok)
            {
                lakarBesok1.Add(new { Datum = besok.Datum, BesökNr = besok.VisitNr, PatientNummer = besok.PatientNr, AnställningsNr = besok.AnstallningsID });
            }

            dataGridViewBefintligaBesok.DataSource = lakarBesok1;
        }
        

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            string visitNr = textBoxBesokNr.Text;
            manageVisitController.RemoveAppointment(visitNr);
            MessageBox.Show("Bokning Borttagen");
            HanteraBesok hanteraBesok = new HanteraBesok();
            hanteraBesok.Show();
            this.Close();
        }
        

        private void buttonRedigeraTid_Click(object sender, EventArgs e)
        {
            string besokNr = textBoxBesokNr.Text;
            DoctorAppointment lakarBesok = manageVisitController.GetVisit(besokNr);
            AndraTidBesok andraTidBesok = new AndraTidBesok(lakarBesok);
            andraTidBesok.Show(); 
            this.Close();

        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            HanteraBesok hanterabesok = new HanteraBesok();
            hanterabesok.Show();
            this.Close();
        }
    }
}

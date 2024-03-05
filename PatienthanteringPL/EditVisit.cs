using PatienthanteringELNy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatienthanteringALNy;
using System.Diagnostics;

namespace PatienthanteringPL
{
    public partial class EditVisit : Form
    {
        GetListsController getListsController = new GetListsController();
        ManageVisitController manageVisitController = new ManageVisitController();
        User ActiveUser { get; set; }
        public EditVisit(User user)
        {
            InitializeComponent();
            ListVisits();
            ActiveUser = user;
        }
        private void ListVisits()
        {
            IList<DoctorAppointment> doctorAppointment = getListsController.GetVisits();
            RefreshDatagridViewVisits(doctorAppointment);
        }
        private void RefreshDatagridViewVisits(IList<DoctorAppointment> lakarBesok)
        {
            List<object> doctorsAppointment = new List<object>();

            foreach (DoctorAppointment besok in lakarBesok)
            {
                doctorsAppointment.Add(new { Datum = besok.Date, BesökNr = besok.VisitNr, Syfte = besok.Reason, Patient = besok.PatientFNamn, Läkare = besok.DoctorFname });
            }

            dataGridViewExistingVisits.DataSource = doctorsAppointment;
        }
        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string visitNr = textBoxBesokNr.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(visitNr))
            {
                MessageBox.Show("Vänligen ange ett besöksnummer.");
                return;
            }

            DoctorAppointment doctorAppointment = manageVisitController.GetVisit(visitNr);
            if (doctorAppointment == null)
            {
                MessageBox.Show("Ingen bokning hittades med det angivna besöksnumret.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Är du säker på att du vill ta bort bokningen?", "Bekräfta borttagning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    manageVisitController.RemoveAppointment(visitNr);
                    MessageBox.Show("Bokning borttagen.");
                    ManageVisits manageVisits = new ManageVisits(ActiveUser);
                    manageVisits.Show();
                    this.Close();
                }
            }
        }
        

        private void buttonEditTime_Click(object sender, EventArgs e)
        {
            string visitNr = textBoxBesokNr.Text.ToUpper();

            
            if (string.IsNullOrWhiteSpace(visitNr))
            {
                MessageBox.Show("Vänligen ange ett besöksnummer.");
                return;
            }
            DoctorAppointment doctorAppointment = manageVisitController.GetVisit(visitNr);
            if (doctorAppointment == null)
            {
                MessageBox.Show("Inget besök hittades med det angivna besöksnumret.");
            }
            else
            {
                
                EditTimeVisit editTimeVisit = new EditTimeVisit(doctorAppointment);
                editTimeVisit.Show();
                this.Close();
            }
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManageVisits manageVisits = new ManageVisits(ActiveUser);
            manageVisits.Show();
            this.Close();
        }
    }
}

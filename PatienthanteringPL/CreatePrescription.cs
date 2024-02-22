using PatienthanteringAL;
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

namespace PatienthanteringPL
{
    public partial class CreatePrescription : Form
    {
        private Patient SelectedPatient { get; }
        User ActiveUser { get; }

        public CreatePrescription(Patient selectedPatient,User user)
        {
            InitializeComponent();
            SelectedPatient = selectedPatient;
            VisaRecept();
            ActiveUser = user;

        }

        private void textBoxPrescription_TextChanged(object sender, EventArgs e)
        {
            string lakemedel = textBoxlakemedel.Text;
        }
        private void textBoxdosage_TextChanged(object sender, EventArgs e)
        {
            string dosering = textBoxdosering.Text;
        }
        private void textBoxReason_TextChanged(object sender, EventArgs e)
        {
            string anledning = textBoxanledning.Text;
        }

        private void buttonCreatePrescription_Click(object sender, EventArgs e)
        {
            string prescriptoin = textBoxlakemedel.Text.Trim();
            string dosage = textBoxdosering.Text.Trim();
            string reason = textBoxanledning.Text.Trim();

            if (string.IsNullOrEmpty(prescriptoin) || string.IsNullOrEmpty(dosage) || string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Fyll i alla fält innan du lägger till receptet.", "Tomma fält", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Avbryt metoden om något av fälten är tomt
            }

            PrescribePrescriptionController prescribePrescriptionController = new PrescribePrescriptionController();
            prescribePrescriptionController.PrescripePrescription(SelectedPatient, prescriptoin, dosage, reason);
            ManagePatients managePatients = new ManagePatients(ActiveUser);
            this.Close();
            managePatients.Show();
        }

        private void VisaRecept()
        {
            GetListsController getListsController = new GetListsController();
            IList<DrugPrescription> drugPrescriptions = getListsController.GetPrescriptions(SelectedPatient);

            List<object> prescriptionDataList = new List<object>();

            foreach (DrugPrescription drugPrescription in drugPrescriptions)
            {
                // Lägg till varje rad som ett anpassat objekt.
                prescriptionDataList.Add(new { Patientnr = SelectedPatient.PatientNr, Lakemedelsrecept = drugPrescription.DrugName, Dosering = drugPrescription.Dosage, Datum = drugPrescription.IssueDate.ToShortDateString(), Anledning = drugPrescription.Reason });
            }

            dataGridViewShowPrescription.DataSource = prescriptionDataList;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ChoosePatientPrescription ChoosePatientPrescription = new ChoosePatientPrescription(ActiveUser);
            this.Close();
            ChoosePatientPrescription.Show();
        }
    }
}

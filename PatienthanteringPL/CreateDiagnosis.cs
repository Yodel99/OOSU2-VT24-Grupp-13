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
using PatienthanteringEL;

namespace PatienthanteringPL
{
    public partial class CreatDiagnosis : Form
    {
        private Patient selectedpatient { get; }
        User ActiveUser { get; }
        
        public CreatDiagnosis(Patient SelectedPatient,User user)
        {
            InitializeComponent();
            selectedpatient = SelectedPatient;
            ShowDiagnosis();
            ActiveUser = user;
        }

        private void textBoxDiagnosisDescription_TextChanged(object sender, EventArgs e)
        {
            string diagnosBeskrivning = textBoxDiagnosBeskrivning.Text;
        }

        private void textBoxTreatmentPlan_TextChanged(object sender, EventArgs e)
        {
            string behandlingsPlan = textBoxBehandlingsplan.Text;
        }

        private void buttonCreateDiagnosis_Click(object sender, EventArgs e)
        {
            string treatment = textBoxBehandlingsplan.Text.Trim();
            string diagnosisDescription = textBoxDiagnosBeskrivning.Text.Trim();

            if (string.IsNullOrEmpty(treatment) || string.IsNullOrEmpty(diagnosisDescription))
            {
                MessageBox.Show("Fyll i alla fält innan du lägger till diagnosen.", "Tomma fält", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Avbryt metoden om något av fälten är tomt
            }

            CreateDiagnosisController createDiagnosisController = new CreateDiagnosisController();
            createDiagnosisController.CreateDiagnosis(selectedpatient, treatment, diagnosisDescription);
            ManagePatients managePatients = new ManagePatients(ActiveUser);
            this.Close();
            managePatients.Show();
        }
        private void ShowDiagnosis()
        {
            GetListsController getListsController = new GetListsController();
            IList<Diagnosis> diagnosis = getListsController.GetDiagnosis(selectedpatient);
            List<object> DiagnosDataList = new List<object>();


                foreach (Diagnosis diagnos in diagnosis)
                {
                    // Lägg till varje rad som ett anpassat objekt.
                    DiagnosDataList.Add(new { Patientnr = selectedpatient.PatientNr, DiagnosBeskrivning = diagnos.DiagnosisDescription, Datum = diagnos.Date.ToShortDateString(), Behandling = diagnos.Treatment });
                }

                dataGridViewShowDiagnosis.DataSource = DiagnosDataList;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            RegisterDiagnosis registerDiagnosis = new RegisterDiagnosis(ActiveUser);
            this.Close();
            registerDiagnosis.Show();
        }
    }
}

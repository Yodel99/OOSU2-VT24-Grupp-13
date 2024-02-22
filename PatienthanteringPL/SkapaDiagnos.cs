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
    public partial class SkapaDiagnos : Form
    {
        private Patient selectedpatient { get; }
        User AktivAnvandare { get; }
        
        public SkapaDiagnos(Patient SelectedPatient,User user)
        {
            InitializeComponent();
            selectedpatient = SelectedPatient;
            VisaDiagnoser();
            AktivAnvandare = user;
        }

        private void textBoxDiagnosBeskrivning_TextChanged(object sender, EventArgs e)
        {
            string diagnosBeskrivning = textBoxDiagnosBeskrivning.Text;
        }

        private void textBoxBehandlingsplan_TextChanged(object sender, EventArgs e)
        {
            string behandlingsPlan = textBoxBehandlingsplan.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string behandling = textBoxBehandlingsplan.Text.Trim();
            string diagnosBeskrivning = textBoxDiagnosBeskrivning.Text.Trim();

            if (string.IsNullOrEmpty(behandling) || string.IsNullOrEmpty(diagnosBeskrivning))
            {
                MessageBox.Show("Fyll i alla fält innan du lägger till diagnosen.", "Tomma fält", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Avbryt metoden om något av fälten är tomt
            }

            SkapaDiagnosController skapaDiagnosController = new SkapaDiagnosController();
            skapaDiagnosController.SkapaDiagnos(selectedpatient, behandling, diagnosBeskrivning);
            PatientHantering patientHantering = new PatientHantering(AktivAnvandare);
            this.Close();
            patientHantering.Show();
        }
        private void VisaDiagnoser()
        {
            HamtaListaController hamtaListaController = new HamtaListaController();
            IList<Diagnos> diagnoser = hamtaListaController.HamtaDiagnoser(selectedpatient);
            List<object> DiagnosDataList = new List<object>();


                foreach (Diagnos diagnos in diagnoser)
                {
                    // Lägg till varje rad som ett anpassat objekt.
                    DiagnosDataList.Add(new { patientnr = selectedpatient.PatientNr, diagnosBeskrivning = diagnos.DiagnosDescription, datum = diagnos.Date.ToShortDateString(), behandling = diagnos.Treatment });
                }

                dataGridViewVisaDiagnos.DataSource = DiagnosDataList;
        }

        private void Tillbakabutton_Click(object sender, EventArgs e)
        {
            ReggaDiagnos reggaDiagnos = new ReggaDiagnos();
            this.Close();
            reggaDiagnos.Show();
        }
    }
}

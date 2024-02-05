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
        
        public SkapaDiagnos(Patient SelectedPatient)
        {
            InitializeComponent();
            selectedpatient = SelectedPatient;
            VisaDiagnoser();
            
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
            
            Patienthantering patienthantering = new Patienthantering();
            string behandling = textBoxBehandlingsplan.Text;
            string diagnosBeskrivning = textBoxDiagnosBeskrivning.Text;
            Diagnos diagnos = patienthantering.SkapaDiagnos(selectedpatient, behandling, diagnosBeskrivning);
            patienthantering.LaggTillDiagnosTillKund(selectedpatient, diagnos);
            PatientHantering patientHantering = new PatientHantering();
            this.Close();
            patientHantering.Show();
        }
        private void VisaDiagnoser()
        {
            Patienthantering patienthantering = new Patienthantering();
            IList<Diagnos> diagnoser = patienthantering.HamtaDiagnoser(selectedpatient);

            List<object> DiagnosDataList = new List<object>();

            foreach (Diagnos diagnos in diagnoser)
            {
                // Lägg till varje rad som ett anpassat objekt.
                DiagnosDataList.Add(new { patientnr = selectedpatient.PatientNr, diagnosBeskrivning = diagnos.Diagnosbeskrivning, datum = diagnos.Datum.ToShortDateString() , behandling = diagnos.Behandling });
            }

            dataGridViewVisaDiagnos.DataSource = DiagnosDataList;
        }
    }
}

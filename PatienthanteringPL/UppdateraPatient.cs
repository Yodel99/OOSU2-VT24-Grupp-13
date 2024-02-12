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
using PatienthanteringDL;
using PatienthanteringEL;

namespace PatienthanteringPL
{
    public partial class UppdateraPatient : Form
    {
        public UppdateraPatient()
        {
            InitializeComponent();
            VisaPatienter();
        }

        private void VisaPatienter()
        {        
            Patienthantering patienthantering = new Patienthantering();
            IList<Patient> patienter = patienthantering.HamtaPatienter();
            dataGridViewVisaPatienter.DataSource = patienter;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            PatientHantering patientHantering = new PatientHantering();

            this.Hide();
            patientHantering.Show();
        }

        private void avslutaProgram_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void uppdateraPatientInfo_Click(object sender, EventArgs e)
        {
            Patienthantering patientHantering = new Patienthantering();
            PatientHantering patienthantering = new PatientHantering();

            string valdPatient = textBoxPatientId.Text.ToLower();
            string valdAttribut = textBoxAttribut.Text.ToLower();
            string valdInput = textBoxInput.Text;

            patientHantering.UppdateraPatientInfo(valdPatient, valdAttribut, valdInput);
            UppdateraPatient uppdateraPatient = new UppdateraPatient();
            this.Hide();
            uppdateraPatient.Show();
        }
    }
}

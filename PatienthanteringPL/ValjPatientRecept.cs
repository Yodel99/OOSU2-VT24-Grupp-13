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
    public partial class ValjPatientRecept : Form
    {
        private Patient SelectedPatient;
        public ValjPatientRecept()
        {
            InitializeComponent();
            VisaPatienter();
        }
        private void VisaPatienter()
        {
            HamtaListaController hamtaListaController = new HamtaListaController();
            IList<Patient> patienter = hamtaListaController.HamtaPatienter();
            dataGridViewVisaPatienter.DataSource = patienter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectedPatient != null)
            {
                SkapaDiagnos skapaDiagnos = new SkapaDiagnos(SelectedPatient);
                this.Close();
                skapaDiagnos.Show();
            }
            else
            {
                MessageBox.Show("Vänligen välj en patient innan du skriver ut ett recept.", "Ingen patient vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewVisaPatienter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVisaPatienter.SelectedRows.Count > 0)
            {
                SelectedPatient = dataGridViewVisaPatienter.SelectedRows[0].DataBoundItem as Patient;
            }
            else
            {
                SelectedPatient = null; // Återställ SelectedPatient om ingen rad är vald
                MessageBox.Show("Vänligen välj en hel rad för att välja en patient.", "Felaktigt val", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Tillbakabutton_Click(object sender, EventArgs e)
        {
            PatientHantering patienthantering = new PatientHantering();
            this.Close();
            patienthantering.Show();
        }
    }
}

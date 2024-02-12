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
    public partial class ReggaDiagnos : Form
    {
        private Patient SelectedPatient;

        public ReggaDiagnos()
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

        private void button1_Click(object sender, EventArgs e)
        {          
            SkapaDiagnos skapaDiagnos = new SkapaDiagnos(SelectedPatient);
            this.Close();
            skapaDiagnos.Show();
        }

        private void dataGridViewVisaPatienter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedPatient = dataGridViewVisaPatienter.SelectedRows[0].DataBoundItem as Patient;
        }
    }
}

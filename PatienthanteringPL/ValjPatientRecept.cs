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
            Patienthantering patienthantering = new Patienthantering();
            IList<Patient> patienter = patienthantering.HamtaPatienter();
            dataGridViewVisaPatienter.DataSource = patienter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkapaRecept skaparecept = new SkapaRecept(SelectedPatient);
            this.Close();
            skaparecept.Show();
        }

        private void dataGridViewVisaPatienter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedPatient = dataGridViewVisaPatienter.SelectedRows[0].DataBoundItem as Patient;
        }
    }
}

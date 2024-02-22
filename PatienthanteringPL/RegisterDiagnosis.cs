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
    //hehehe
    public partial class RegisterDiagnosis : Form
    {
        private Patient SelectedPatient;
        User ActiveUser {  get; }

        public RegisterDiagnosis(User user)
        {
            InitializeComponent();
            ShowPatients();
            ActiveUser = user;
        }

        private void ShowPatients()
        {
            GetListsController getListsController = new GetListsController();
            IList<Patient> patients = getListsController.GetPatients();
            dataGridViewShowPatients.DataSource = patients;
        }

        private void buttonRegisterDiagnosis_Click(object sender, EventArgs e)
        {
            if (SelectedPatient != null)
            {
                CreatDiagnosis createDiagnosis = new CreatDiagnosis(SelectedPatient,ActiveUser);
                this.Close();
                createDiagnosis.Show();
            }
            else
            {
                MessageBox.Show("Vänligen välj en patient innan du skapar en diagnos.", "Ingen patient vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewShowPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewShowPatients.SelectedRows.Count > 0)
            {
                SelectedPatient = dataGridViewShowPatients.SelectedRows[0].DataBoundItem as Patient;
            }
            else
            {
                SelectedPatient = null; // Återställ SelectedPatient om ingen rad är vald
                MessageBox.Show("Vänligen välj en hel rad för att välja en patient.", "Felaktigt val", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagePatients managePatients = new ManagePatients(ActiveUser);
            this.Close();
            managePatients.Show();
        }
    }
}

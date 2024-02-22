using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatienthanteringAL;
using PatienthanteringDLef;
using PatienthanteringEL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace PatienthanteringPL
{
    public partial class UpdatePatient : Form
    {
        User ActiveUser { get; }
        public UpdatePatient(User user)
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

        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagePatients managePatients = new ManagePatients(ActiveUser);
            this.Hide();
            managePatients.Show();
        }

        private void buttonUpdatePatientInfo_Click(object sender, EventArgs e)
        {            
            UpdatePatientController updatePatientController = new UpdatePatientController();             
            
            using (var db = new PatientMSContext())
            {
                string chosenPatient = textBoxPatientId.Text.ToLower();
                string chosenAttribute = textBoxAttribut.Text.ToLower();
                string chosenInput = textBoxInput.Text;
                bool checkPatientNr = false;
                bool checkAttribut = false;

                var foundPatient = db.Patients.Find(chosenPatient);
                if (foundPatient != null)
                {
                    checkPatientNr = true;
                }

                if (chosenAttribute == "address")
                {
                    checkAttribut = true;
                }
                else if (chosenAttribute == "email")
                {
                    checkAttribut = true;

                }
                else if (chosenAttribute == "telnr")
                {
                    checkAttribut = true;
                }
                else if (chosenAttribute == "fname")
                {
                    checkAttribut = true;
                }
                else if (chosenAttribute == "ename")
                {
                    checkAttribut = true;
                }
                else if (chosenAttribute == "ssn")
                {
                    checkAttribut = true;
                }

                updatePatientController.UpdatePatientInfo(chosenPatient, chosenAttribute, chosenInput);

                if (checkPatientNr && checkAttribut == true)
                {
                    updatePatientController.UpdatePatientInfo(chosenPatient, chosenAttribute, chosenInput);
                    UpdatePatient updatePatient = new UpdatePatient(ActiveUser);
                    this.Hide();
                    updatePatient.Show();
                }
                else if (checkPatientNr == true && checkAttribut == false)
                {
                    MessageBox.Show("Inte ett giltligt attribut, testa igen.");
                }
                else if (checkPatientNr == false && checkAttribut == true)
                {
                    MessageBox.Show("Inte ett giltligt patientnummer, testa igen.");
                }
                else if (checkPatientNr == false && checkAttribut == false)
                {
                    MessageBox.Show("Både patientnummret och attributen var ogiltigt, testa igen.");
                }
            }

           
        }
    }
}

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
    public partial class UppdateraPatient : Form
    {
        User AktivAnvandare { get; }
        public UppdateraPatient(User user)
        {
            InitializeComponent();
            VisaPatienter();
            AktivAnvandare = user;
        }

        private void VisaPatienter()
        {        
            HamtaListaController hamtaListaController = new HamtaListaController();
            IList<Patient> patienter = hamtaListaController.HamtaPatienter();
            dataGridViewVisaPatienter.DataSource = patienter;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            PatientHantering patientHantering = new PatientHantering(AktivAnvandare);

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
            UppdateraPatientController uppdateraPatientController = new UppdateraPatientController();             
            
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
                else if (chosenAttribute == "fnamn")
                {
                    checkAttribut = true;
                }
                else if (chosenAttribute == "lnamn")
                {
                    checkAttribut = true;
                }
                else if (chosenAttribute == "ssn")
                {
                    checkAttribut = true;
                }

                uppdateraPatientController.UppdateraPatientInfo(chosenPatient, chosenAttribute, chosenInput);

                if (checkPatientNr && checkAttribut == true)
                {
                    uppdateraPatientController.UppdateraPatientInfo(chosenPatient, chosenAttribute, chosenInput);
                    UppdateraPatient uppdateraPatient = new UppdateraPatient(AktivAnvandare);

                    this.Hide();
                    uppdateraPatient.Show();
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

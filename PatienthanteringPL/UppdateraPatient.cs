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
            HamtaListaController hamtaListaController = new HamtaListaController();
            IList<Patient> patienter = hamtaListaController.HamtaPatienter();
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
            UppdateraPatientController uppdateraPatientController = new UppdateraPatientController();            
            UnitOfWork unitOfWork = new UnitOfWork();   

            string valdPatient = textBoxPatientId.Text.ToLower();
            string valdAttribut = textBoxAttribut.Text.ToLower();
            string valdInput = textBoxInput.Text;
            bool checkPatientNr = false;
            bool checkAttribut = false;

            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr.ToLower() == valdPatient))
            {
                checkPatientNr = true;
            }

            if (valdAttribut == "adress")
            {
                checkAttribut = true;
            }
            else if (valdAttribut == "email")
            {
                checkAttribut = true;

            }
            else if (valdAttribut == "telnr")
            {
                checkAttribut = true;
            }
            else if (valdAttribut == "fnamn")
            {
                checkAttribut = true;
            }
            else if (valdAttribut == "enamn")
            {
                checkAttribut = true;
            }
            else if (valdAttribut == "personnr")
            {
                checkAttribut = true;
            }
            
            uppdateraPatientController.UppdateraPatientInfo(valdPatient, valdAttribut, valdInput);

            if (checkPatientNr && checkAttribut == true)
            {
                uppdateraPatientController.UppdateraPatientInfo(valdPatient, valdAttribut, valdInput);
                UppdateraPatient uppdateraPatient = new UppdateraPatient();
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

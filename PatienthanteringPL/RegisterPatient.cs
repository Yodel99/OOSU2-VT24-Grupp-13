using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatienthanteringALNy;
using PatienthanteringELNy;

namespace PatienthanteringPL
{
    public partial class RegisterPatient : Form
    {
        GetListsController getListsController = new GetListsController();
        RegisterPatientController registerPatientController = new RegisterPatientController();
        User ActiveUser { get; }
        public RegisterPatient(User user)
        {
            InitializeComponent();
            ShowPatients();
            ActiveUser = user;
        }

        public void ShowPatients()
        {
 
            IList<Patient> patients = getListsController.GetPatients(); 
            dataGridViewShowPatients.DataSource = patients;
        }

        
        private void buttonRegisterPatient_Click(object sender, EventArgs e)
        {
            
            ManagePatients managePatients = new ManagePatients (ActiveUser);
            string personNmr = textBox1.Text;
            string fnamn= textBox2.Text;
            string enamn = textBox3.Text;
            string email = textBox4.Text;
            string patientNmr = textBox5.Text.ToUpper();
            string adress = textBox6.Text;
            string telNmr= textBox7.Text;
            

            if (!string.IsNullOrEmpty(personNmr) && !string.IsNullOrEmpty(fnamn) && !string.IsNullOrEmpty(enamn) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(patientNmr) && !string.IsNullOrEmpty(adress) && !string.IsNullOrEmpty(telNmr) && registerPatientController.GetPatient(patientNmr) == null&& patientNmr.StartsWith("P-"))
            {
                
                registerPatientController.RegisterPatient(personNmr, fnamn, enamn, email, patientNmr, adress, telNmr);
                MessageBox.Show("Patient registrerad");
                this.Hide();
                managePatients.Show();
            }
            else 
            {
                MessageBox.Show("Fel inmatning, försök igen!");

            }

            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagePatients managePatients = new ManagePatients(ActiveUser);
            this.Hide();
            managePatients.Show();
        }
    }
}

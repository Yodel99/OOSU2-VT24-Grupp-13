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
    public partial class RegistreraPatient : Form
    {
        HamtaListaController hamtaListaController = new HamtaListaController();
        public RegistreraPatient()
        {
            InitializeComponent();
            VisaPatienter();
        }

        public void VisaPatienter()
        {
            Patienthantering patienthantering = new Patienthantering(); 
            IList<Patient> patienter = hamtaListaController.HamtaPatienter(); 
            dataGridViewVisaPatienter.DataSource = patienter;
        }

        
        private void registrerapersonuppgifter1_Click(object sender, EventArgs e)
        {
            Patienthantering patienthantering = new Patienthantering();
            PatientHantering PatienthanteringWindow = new PatientHantering ();
            RegistreraPatientController registreraPatientController = new RegistreraPatientController();
            string personNmr = textBox1.Text;
            string fnamn= textBox2.Text;
            string enamn = textBox3.Text;
            string email = textBox4.Text;
            string patientNmr = textBox5.Text;
            string adress = textBox6.Text;
            string telNmr= textBox7.Text;
            

            if (!string.IsNullOrEmpty(personNmr) && !string.IsNullOrEmpty(fnamn) && !string.IsNullOrEmpty(enamn) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(patientNmr) && !string.IsNullOrEmpty(adress) && !string.IsNullOrEmpty(telNmr))
            {
                registreraPatientController.RegistreraPatient(personNmr, fnamn, enamn, email, patientNmr, adress, telNmr);
                this.Hide();
                PatienthanteringWindow.Show();
            }
            else 
            {
                MessageBox.Show("Fel inmatning, försök igen!");

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientHantering patientHantering = new PatientHantering();

            this.Hide();
            patientHantering.Show();
        }
    }
}

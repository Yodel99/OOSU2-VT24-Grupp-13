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
    public partial class ManagePatients : Form
    {

        User ActiveUser { get; set; }
        ValidationController validationController=new ValidationController();

        public ManagePatients(User user)
        {           
            InitializeComponent();
            ActiveUser = user;
        }


        private void buttonRegisterPatient_Click(object sender, EventArgs e)
        {
            if (validationController.AccessCheckNurse(ActiveUser)==true)
            {
                RegisterPatient registerPatient = new RegisterPatient(ActiveUser);
                this.Hide();
                registerPatient.Show();
            }
            else
            {
                MessageBox.Show("Ej giltig access!");
            }
            
        }

        private void buttonRegisterDiagnosis_Click(object sender, EventArgs e)
        {
            if (validationController.AccessCheckDoctor(ActiveUser) == true)
            {
                RegisterDiagnosis registerDiagnosis = new RegisterDiagnosis(ActiveUser);
                this.Close();
                registerDiagnosis.Show();
            }
            else
            {
                MessageBox.Show("Ej giltig access!");
            }
            
        }

        private void buttonChoosePrescription_Click(object sender, EventArgs e)
        {

            if (validationController.AccessCheckDoctor(ActiveUser) == true)
            {
                ChoosePatientPrescription choosePatientPrescription = new ChoosePatientPrescription(ActiveUser);
                this.Close();
                choosePatientPrescription.Show();
            }
            else
            {
                MessageBox.Show("Ej giltig access!");
            }
            
        }

        private void buttonUpdatePatient_Click(object sender, EventArgs e)
        {
            if (validationController.AccessCheckNurse(ActiveUser) == true)
            {
                UpdatePatient updatePatient = new UpdatePatient(ActiveUser);
                this.Hide();
                updatePatient.Show();
            }
            else
            {
                MessageBox.Show("Ej giltig access!");
            }
            
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(ActiveUser);

            this.Hide();
            mainMenu.Show();
        }
    }
}

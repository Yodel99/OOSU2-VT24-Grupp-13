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
    public partial class PatientHantering : Form
    {

        User AktivAnvandare { get;}
        ValidationController validationController=new ValidationController();

        public PatientHantering(User user)
        {           
            InitializeComponent();
            AktivAnvandare = user;
        }


        private void registreraPatient_Click(object sender, EventArgs e)
        {
            if (validationController.AccessCheckNurse(AktivAnvandare)==true)
            {
                RegistreraPatient registreraPatient = new RegistreraPatient(AktivAnvandare);
                this.Hide();
                registreraPatient.Show();
            }
            else
            {
                MessageBox.Show("Ej giltig access");
            }
            
        }

        private void registreraDiagnos_Click(object sender, EventArgs e)
        {
            if (validationController.AccessCheckDoctor(AktivAnvandare) == true)
            {
                ReggaDiagnos reggaDiagnos = new ReggaDiagnos();
                this.Close();
                reggaDiagnos.Show();
            }
            else
            {
                MessageBox.Show("Ej giltig access");
            }
            
        }

        private void skrivUtLakemedel_Click(object sender, EventArgs e)
        {

            if (validationController.AccessCheckDoctor(AktivAnvandare) == true)
            {
                ValjPatientRecept valjPatientRecept = new ValjPatientRecept(AktivAnvandare);
                this.Close();
                valjPatientRecept.Show();
            }
            else
            {
                MessageBox.Show("Ej giltig access");
            }
            
        }

        private void uppdateraPatient_Click(object sender, EventArgs e)
        {
            if (validationController.AccessCheckNurse(AktivAnvandare) == true)
            {
                UppdateraPatient uppdateraPatient = new UppdateraPatient(AktivAnvandare);
                this.Hide();
                uppdateraPatient.Show();
            }
            else
            {
                MessageBox.Show("Ej giltig access");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Huvudmeny huvudmeny = new Huvudmeny(AktivAnvandare);

            this.Hide();
            huvudmeny.Show();
        }
    }
}

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

       public User AktivAnvandare { get; }

        public PatientHantering()
        {           
            InitializeComponent();           
        }


        private void registreraPatient_Click(object sender, EventArgs e)
        {
            RegistreraPatient registreraPatient = new RegistreraPatient(); 
            this.Hide(); 
            registreraPatient.Show();
        }

        private void registreraDiagnos_Click(object sender, EventArgs e)
        {
            ReggaDiagnos reggaDiagnos = new ReggaDiagnos();
            this.Close();
            reggaDiagnos.Show();
        }

        private void skrivUtLakemedel_Click(object sender, EventArgs e)
        {
            ValjPatientRecept valjPatientRecept = new ValjPatientRecept();
            this.Close();
            valjPatientRecept.Show();
        }

        private void uppdateraPatient_Click(object sender, EventArgs e)
        {
            UppdateraPatient uppdateraPatient = new UppdateraPatient();

            this.Hide();
            uppdateraPatient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Huvudmeny huvudmeny = new Huvudmeny();

            this.Hide();
            huvudmeny.Show();
        }
    }
}

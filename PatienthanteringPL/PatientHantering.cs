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
    }
}

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

        private void uppdateraPatient_Click(object sender, EventArgs e)
        {
            UppdateraPatient uppdateraPatient = new UppdateraPatient();

            this.Hide();
            uppdateraPatient.Show();
        }
    }
}

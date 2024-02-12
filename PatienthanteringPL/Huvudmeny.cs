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
    public partial class Huvudmeny : Form
    {
        public Anvandare AktivAnvandare { get; }
        public Huvudmeny()
        {           
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientHantering patientHantering = new PatientHantering();
            this.Hide();
            patientHantering.Show();
        }

        private void hanteraPatient_Click(object sender, EventArgs e)
        {
            HanteraBesok hanteraBesok = new HanteraBesok();
            this.Hide();
            hanteraBesok.Show();
        }

        
    }
}

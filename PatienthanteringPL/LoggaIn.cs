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
using PatienthanteringDL;
using PatienthanteringEL;

namespace PatienthanteringPL
{
    public partial class LoggaIn : Form
    {
        public LoggaIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patienthantering patienthantering = new Patienthantering();

            string inloggID = InloggsIDtextBox1.Text;
            string losenord = LosenordtextBox2.Text;

            Anvandare inloggadAnvandare = patienthantering.GetAnvandare(inloggID, losenord);           

            if (inloggadAnvandare != null)
            {
                Huvudmeny huvudmeny = new Huvudmeny(inloggadAnvandare);
                this.Hide();
                huvudmeny.Show();
            }
            else
            {
                Felinlogg felinlogg = new Felinlogg();
                this.Hide();
                felinlogg.Show();
            }



        }
    }
}

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
    public partial class Felinlogg : Form
    {
        public Felinlogg()
        {
            InitializeComponent();
        }

        private void FörsökIgenbutton1_Click(object sender, EventArgs e)
        {
            LoggaIn loggain = new LoggaIn();
            this.Hide();
            loggain.Show();
        }
    }
}

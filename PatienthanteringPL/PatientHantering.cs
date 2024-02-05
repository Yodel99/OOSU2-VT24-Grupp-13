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

       public Anvandare AktivAnvandare { get; }

        public PatientHantering(Anvandare aktivanvandare)
        {
            AktivAnvandare = aktivanvandare;
            InitializeComponent();           
        }

    }
}

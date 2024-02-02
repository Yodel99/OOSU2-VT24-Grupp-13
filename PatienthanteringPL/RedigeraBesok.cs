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
using PatienthanteringAL;

namespace PatienthanteringPL
{
    public partial class RedigeraBesok : Form
    {
        Patienthantering patienthantering = new Patienthantering();
        public RedigeraBesok()
        {
            InitializeComponent();
            HamtaBesok();
        }
        private void HamtaBesok()
        {
            IList<LakarBesok> lakarBesok = patienthantering.HamtaBesok();
            dataGridViewBefintligaBesok.DataSource= lakarBesok;
        }
    }
}

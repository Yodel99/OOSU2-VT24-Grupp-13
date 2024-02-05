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
    public partial class HanteraBesok : Form
    {

        public Anvandare AktivAnvandare { get; }
        public HanteraBesok()
        {          
            InitializeComponent();
        }

        private void HanteraBesok_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NyttBesok nyttBesok = new NyttBesok();
            this.Close();
            nyttBesok.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RedigeraBesok redigeraBesok= new RedigeraBesok();
            this.Close();
            redigeraBesok.Show();
        }

        private void buttonHuvudMeny_Click(object sender, EventArgs e)
        {
            Huvudmeny huvudmeny = new Huvudmeny();
            huvudmeny.Show();
            this.Close();
        }
    }
}

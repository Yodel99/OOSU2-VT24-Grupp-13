using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatienthanteringEL;

namespace PatienthanteringPL
{
    public partial class KvittensBokning : Form
    {
        public LakarBesok LakarBesok { get; }
        public KvittensBokning(LakarBesok lakarBesok)
        {
            InitializeComponent();
            LakarBesok = lakarBesok;
            VisaKvittens(lakarBesok);
        }
        private void VisaKvittens(LakarBesok lakarBesok)
        {
            RefreshDatagridViewBesok(lakarBesok);
        }
        private void RefreshDatagridViewBesok(LakarBesok lakarBesok)
        {
            List <LakarBesok> datagridveiew= new List<LakarBesok> ();
            datagridveiew.Add (lakarBesok);
            List<object> lakarBesok1 = new List<object>();
                

            foreach (LakarBesok besok in datagridveiew)
            {
                lakarBesok1.Add(new { Datum = besok.Datum, BesökNr = besok.BesokNr, PatientNummer = besok.PatientNr, Patient = besok.PatientFNamn, AnställningsNr = besok.AnstallningsID, Läkare = besok.LakareFnamn });
            }

            dataGridViewKvittens.DataSource = lakarBesok1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HanteraBesok hanteraBesok = new HanteraBesok();
            hanteraBesok.Show();
            this.Close();
        }
    }
}

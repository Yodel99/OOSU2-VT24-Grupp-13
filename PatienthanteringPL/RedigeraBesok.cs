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
using System.Diagnostics;

namespace PatienthanteringPL
{
    public partial class RedigeraBesok : Form
    {
        HanteraBesokController hanteraBesokController = new HanteraBesokController();

        public RedigeraBesok()
        {
            InitializeComponent();
            ListaBesok();
        }
        private void ListaBesok()
        {
            IList<LakarBesok> lakarBesok = hanteraBesokController.ListaBesok();
            RefreshDatagridViewBesok(lakarBesok);
        }
        private void RefreshDatagridViewBesok(IList<LakarBesok> lakarBesok)
        {
            List<object> lakarBesok1 = new List<object>();

            foreach (LakarBesok besok in lakarBesok)
            {
                lakarBesok1.Add(new { Datum = besok.Datum, BesökNr = besok.BesokNr, PatientNummer = besok.PatientNr, AnställningsNr = besok.AnstallningsID });
            }

            dataGridViewBefintligaBesok.DataSource = lakarBesok1;
        }


        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            string besokNr = textBoxBesokNr.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(besokNr))
            {
                MessageBox.Show("Vänligen ange ett besöksnummer.");
                return;
            }

            LakarBesok lakarBesok = hanteraBesokController.HamtaBesok(besokNr);
            if (lakarBesok == null)
            {
                MessageBox.Show("Ingen bokning hittades med det angivna besöksnumret.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Är du säker på att du vill ta bort bokningen?", "Bekräfta borttagning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    hanteraBesokController.TaBortBesok(besokNr);
                    MessageBox.Show("Bokning borttagen.");
                    HanteraBesok hanteraBesok = new HanteraBesok();
                    hanteraBesok.Show();
                    this.Close();
                }
            }
        }


        private void buttonRedigeraTid_Click(object sender, EventArgs e)
        {
            string besokNr = textBoxBesokNr.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(besokNr))
            {
                MessageBox.Show("Vänligen ange ett besöksnummer.");
                return;
            }

            LakarBesok lakarBesok = hanteraBesokController.HamtaBesok(besokNr);
            if (lakarBesok == null)
            {
                MessageBox.Show("Inget besök hittades med det angivna besöksnumret.");
            }
            else
            {
                AndraTidBesok andraTidBesok = new AndraTidBesok(lakarBesok);
                andraTidBesok.Show();
                this.Close();
            }
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            HanteraBesok hanterabesok = new HanteraBesok();
            hanterabesok.Show();
            this.Close();
        }
    }
}

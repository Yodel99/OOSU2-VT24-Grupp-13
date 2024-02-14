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
        public DoctorAppointment LakarBesok { get; }
        public KvittensBokning(DoctorAppointment lakarBesok)
        {
            InitializeComponent();
            LakarBesok = lakarBesok;
            VisaKvittens(lakarBesok);
        }
        private void VisaKvittens(DoctorAppointment lakarBesok)
        {
            RefreshDatagridViewBesok(lakarBesok);
        }
        private void RefreshDatagridViewBesok(DoctorAppointment lakarBesok)
        {
            List <DoctorAppointment> datagridveiew= new List<DoctorAppointment> ();
            datagridveiew.Add (lakarBesok);
            List<object> lakarBesok1 = new List<object>();
                

            foreach (DoctorAppointment besok in datagridveiew)
            {
                lakarBesok1.Add(new { Datum = besok.Datum, BesökNr = besok.VisitNr, PatientNummer = besok.PatientNr, Patient = besok.PatientFNamn, AnställningsNr = besok.AnstallningsID, Läkare = besok.LakareFnamn });
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

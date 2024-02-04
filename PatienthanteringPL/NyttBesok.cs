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
using PatienthanteringEL;

namespace PatienthanteringPL
{
    public partial class NyttBesok : Form
    {
        Patienthantering patienthantering = new Patienthantering();
        public NyttBesok()
        {
            InitializeComponent();
            ListaPatienter();
            ListaSjukSkotare();
            ModifieraDatePicker();
        }
        private void RefreshDatagridViewPatient(IList<Patient> patientlista)
        {
            List<object> patienter = new List<object>();

            foreach (Patient patient in patientlista)
            {
                patienter.Add(new { Förnamn = patient.FNamn, Efternamn = patient.ENamn, PatientNummer = patient.PatientNr});
            }

            dataGridViewPatienter.DataSource = patienter;
        }
        private void RefreshDatagridViewSjukskotare(IList<VardPersonal> sjuksKotare)
        {
            List<object> sjukSkotareLista = new List<object>();
      
            foreach (VardPersonal sjukSkotare1 in sjuksKotare)
            {
                sjukSkotareLista.Add(new { Förnamn = sjukSkotare1.FNamn, Efternamn = sjukSkotare1.ENamn, Anställningsnummer = sjukSkotare1.AnstallningsNr });
            }

            dataGridViewSjukSkotare.DataSource = sjukSkotareLista;
        }
        private void ModifieraDatePicker()
        {
            dateTimePickerBesok.Format = DateTimePickerFormat.Custom;
            dateTimePickerBesok.CustomFormat = "yyyy-MM-dd HH:mm";


            dateTimePickerBesok.ShowUpDown = true;
        }
        private void ListaPatienter()
        {
            IList<Patient> patienter = patienthantering.ListaPatienter();

            RefreshDatagridViewPatient(patienter);
        }
        private void ListaSjukSkotare()
        {
            IList<VardPersonal> sjukSkotare = patienthantering.ListaSjukSkotare();
            RefreshDatagridViewSjukskotare(sjukSkotare);
        }
        private void SkapaBesok()
        {
            
            string aNummerLakare;
            string patientNummer;
            string syfte;
            DateTime datum;
            string besokNummer;

            aNummerLakare = textBoxANummerLakare.Text;
            patientNummer = textBoxPatientNummer.Text;
            syfte = textBoxSyfte.Text;
            datum = dateTimePickerBesok.Value;
            besokNummer = textBoxBesokNummer.Text;

            VardPersonal lakare = HamtaLakare(aNummerLakare);
            Patient patient = HamtaPatient(patientNummer);
            if (lakare == null)
            {
                Felmeddelande felmeddelande = new Felmeddelande();
                felmeddelande.Show();
            }
            else if (patient == null)
            {
                Felmeddelande felmeddelande = new Felmeddelande();
                felmeddelande.Show();
            }
            
            LakarBesok lakarBesok = new LakarBesok(besokNummer, datum, syfte, patient, lakare);
            
            patienthantering.LaggTillBesok(lakarBesok);
            VisaKvittens(lakarBesok);
        }
        private Patient HamtaPatient(string patientNummer)
        {
            return patienthantering.HamtaPatient(patientNummer);
        }
        private VardPersonal HamtaLakare(string anstallningsNummer)
        {
            return patienthantering.HamtaLakare(anstallningsNummer);
        }
        private void VisaKvittens(LakarBesok lakarBesok)
        {
            KvittensBokning kvittensBokning = new KvittensBokning(lakarBesok);
            kvittensBokning.Show();
            this.Close();
        }

        private void buttonLaggTillBesok_Click(object sender, EventArgs e)
        {
            SkapaBesok();
            
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            HanteraBesok hanterabesok = new HanteraBesok();
            hanterabesok.Show();
            this.Close();
        }
    }
}

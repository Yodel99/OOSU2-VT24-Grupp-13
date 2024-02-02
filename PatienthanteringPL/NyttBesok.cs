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
    }
}

using PatienthanteringAL;
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
    public partial class SkapaRecept : Form
    {
        private Patient selectedpatient { get; }

        public SkapaRecept(Patient SelectedPatient)
        {
            InitializeComponent();
            selectedpatient = SelectedPatient;
            VisaRecept();
        }

        private void textBoxlakemedel_TextChanged(object sender, EventArgs e)
        {
            string lakemedel = textBoxlakemedel.Text;
        }
        private void textBoxdosering_TextChanged(object sender, EventArgs e)
        {
            string dosering = textBoxdosering.Text;
        }
        private void textBoxanledning_TextChanged(object sender, EventArgs e)
        {
            string anledning = textBoxanledning.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patienthantering patienthantering = new Patienthantering();
            string lakemedel = textBoxlakemedel.Text;
            string dosering = textBoxdosering.Text;
            string anledning = textBoxanledning.Text;
            Lakemedelsrecept lakemedelsrecept = patienthantering.SkapaRecept(selectedpatient, lakemedel, dosering, anledning);   
            PatientHantering patientHantering = new PatientHantering();
            this.Close();
            patientHantering.Show();
        }
        private void VisaRecept()
        {
            Patienthantering patienthantering = new Patienthantering();
            IList<Lakemedelsrecept> lakemedelsrecept = patienthantering.HamtaRecept(selectedpatient);

            List<object> receptDataList = new List<object>();

            foreach (Lakemedelsrecept lakemedelsrecept1 in lakemedelsrecept)
            {
                // Lägg till varje rad som ett anpassat objekt.
                receptDataList.Add(new { patientnr = selectedpatient.PatientNr, lakemedelsrecept = lakemedelsrecept1.LakemedelsNamn, dosering = lakemedelsrecept1.Dosering, datum = lakemedelsrecept1.Utskrivningsdatum.ToShortDateString(), anledning = lakemedelsrecept1.Anledning });
            }

            dataGridViewVisaRecept.DataSource = receptDataList;
        }
    }
}

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
    //hehehehe
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
            string lakemedel = textBoxlakemedel.Text.Trim();
            string dosering = textBoxdosering.Text.Trim();
            string anledning = textBoxanledning.Text.Trim();

            if (string.IsNullOrEmpty(lakemedel) || string.IsNullOrEmpty(dosering) || string.IsNullOrEmpty(anledning))
            {
                MessageBox.Show("Fyll i alla fält innan du lägger till receptet.", "Tomma fält", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Avbryt metoden om något av fälten är tomt
            }

            SkrivUtReceptController skrivUtReceptController = new SkrivUtReceptController();
            Lakemedelsrecept lakemedelsrecept = skrivUtReceptController.SkapaRecept(selectedpatient, lakemedel, dosering, anledning);
            PatientHantering patientHantering = new PatientHantering();
            this.Close();
            patientHantering.Show();
        }
        private void VisaRecept()
        {
            SkrivUtReceptController skrivUtReceptController = new SkrivUtReceptController();
            IList<Lakemedelsrecept> lakemedelsrecept = skrivUtReceptController.HamtaRecept(selectedpatient);

            List<object> receptDataList = new List<object>();

            foreach (Lakemedelsrecept lakemedelsrecept1 in lakemedelsrecept)
            {
                // Lägg till varje rad som ett anpassat objekt.
                receptDataList.Add(new { patientnr = selectedpatient.PatientNr, lakemedelsrecept = lakemedelsrecept1.LakemedelsNamn, dosering = lakemedelsrecept1.Dosering, datum = lakemedelsrecept1.Utskrivningsdatum.ToShortDateString(), anledning = lakemedelsrecept1.Anledning });
            }

            dataGridViewVisaRecept.DataSource = receptDataList;
        }

        private void Tillbakabutton_Click(object sender, EventArgs e)
        {
            ValjPatientRecept valjPatientRecept = new ValjPatientRecept();
            this.Close();
            valjPatientRecept.Show();
        }
    }
}

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
        User AktivAnvandare { get; }

        public SkapaRecept(Patient SelectedPatient,User user)
        {
            InitializeComponent();
            selectedpatient = SelectedPatient;
            VisaRecept();
            AktivAnvandare = user;

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
            skrivUtReceptController.SkapaRecept(selectedpatient, lakemedel, dosering, anledning);
            PatientHantering patientHantering = new PatientHantering(AktivAnvandare);
            this.Close();
            patientHantering.Show();
        }

        private void VisaRecept()
        {
            HamtaListaController hamtaListaController = new HamtaListaController();
            IList<DrugPrescription> lakemedelsrecept = hamtaListaController.HamtaRecept(selectedpatient);

            List<object> receptDataList = new List<object>();

            foreach (DrugPrescription lakemedelsrecept1 in lakemedelsrecept)
            {
                // Lägg till varje rad som ett anpassat objekt.
                receptDataList.Add(new { patientnr = selectedpatient.PatientNr, lakemedelsrecept = lakemedelsrecept1.DrugName, dosering = lakemedelsrecept1.Dosage, datum = lakemedelsrecept1.IssueDate.ToShortDateString(), anledning = lakemedelsrecept1.Reason });
            }

            dataGridViewVisaRecept.DataSource = receptDataList;
        }

        private void Tillbakabutton_Click(object sender, EventArgs e)
        {
            ValjPatientRecept valjPatientRecept = new ValjPatientRecept(AktivAnvandare);
            this.Close();
            valjPatientRecept.Show();
        }
    }
}

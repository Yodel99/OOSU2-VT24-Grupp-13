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
        ManageVisitController manageVisitController = new ManageVisitController();
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
                patienter.Add(new { Förnamn = patient.FName, Efternamn = patient.EName, PatientNummer = patient.PatientNr});
            }

            dataGridViewPatienter.DataSource = patienter;
        }
        private void RefreshDatagridViewSjukskotare(IList<NursingStaff> sjuksKotare)
        {
            List<object> sjukSkotareLista = new List<object>();
      
            foreach (NursingStaff sjukSkotare1 in sjuksKotare)
            {
                sjukSkotareLista.Add(new { Förnamn = sjukSkotare1.FName, Efternamn = sjukSkotare1.EName, Anställningsnummer = sjukSkotare1.StaffNr });
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
            IList<Patient> patienter = manageVisitController.GetPatients();

            RefreshDatagridViewPatient(patienter);
        }
        private void ListaSjukSkotare()
        {
            IList<NursingStaff> sjukSkotare = manageVisitController.ListNursingStaffs();
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

            NursingStaff lakare = HamtaLakare(aNummerLakare);
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
            
            DoctorAppointment doctorAppointment = new DoctorAppointment(besokNummer, datum, syfte, patient, lakare);
            
            manageVisitController.AddVisit(doctorAppointment);
            VisaKvittens(doctorAppointment);
        }
        private Patient HamtaPatient(string patientNr)
        {
            return manageVisitController.GetPatient(patientNr);
        }
        private NursingStaff HamtaLakare(string staffNr)
        {
            return manageVisitController.GetDoctor(staffNr);
        }
        private void VisaKvittens(DoctorAppointment lakarBesok)
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

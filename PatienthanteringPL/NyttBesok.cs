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
        HamtaListaController hamtaListaController = new HamtaListaController();
        ManageVisitController manageVisitController = new ManageVisitController();
        public NyttBesok()
        {
            InitializeComponent();
            ListPatients();
            ListNurses();
            ModifyDatePicker();
        }
        private void RefreshDatagridViewPatient(IList<Patient> patientlista)
        {
            List<object> patienter = new List<object>();

            foreach (Patient patient in patientlista)
            {
                patienter.Add(new { Förnamn = patient.FName, Efternamn = patient.EName, PatientNummer = patient.PatientNr });
            }

            dataGridViewPatienter.DataSource = patienter;
        }
        private void RefreshDatagridViewSjukskotare(IList<NursingStaff> nursingStaff)
        {
            List<object> nursingStaffList = new List<object>();

            foreach (NursingStaff nurse in nursingStaff)
            {
                nursingStaffList.Add(new { Förnamn = nurse.FName, Efternamn = nurse.EName, Anställningsnummer =nurse.StaffNr });
            }

            dataGridViewSjukSkotare.DataSource = nursingStaffList;
        }
        private void ModifyDatePicker()
        {
            dateTimePickerBesok.Format = DateTimePickerFormat.Custom;
            dateTimePickerBesok.CustomFormat = "yyyy-MM-dd HH:mm";


            dateTimePickerBesok.ShowUpDown = true;
        }
        private void ListPatients()
        {
            IList<Patient> patienter = manageVisitController.GetPatients();

            RefreshDatagridViewPatient(patienter);
        }
        private void ListNurses()
        {
            IList<NursingStaff> sjukSkotare = hamtaListaController.ListNursingStaffs();
            RefreshDatagridViewSjukskotare(sjukSkotare);
        }
        private void CreateVisit()
        {
            
            string aNummerLakare = textBoxANummerLakare.Text.ToUpper();
            string patientNummer = textBoxPatientNummer.Text.ToUpper();
            string syfte = textBoxSyfte.Text;
            DateTime datum = dateTimePickerBesok.Value;
            string visitNr = textBoxBesokNummer.Text.ToUpper();

            try
            {
                NursingStaff doctor = manageVisitController.GetDoctor(aNummerLakare);
                Patient patient = manageVisitController.GetPatient(patientNummer);
                DoctorAppointment doctorAppointmentCheck = manageVisitController.GetVisit(visitNr);

                if (doctorAppointmentCheck!=null||doctor == null || patient == null || !IsValidBesokNummer(visitNr) || !IsValidLakare(doctor))
                {
                    MessageBox.Show("Felaktigt ifyllt fält, Var god att kontrollera");
                    return;
                }

                DoctorAppointment doctorAppointment = new DoctorAppointment(visitNr, datum, syfte, patient, doctor);
                manageVisitController.AddVisit(doctorAppointment);
                VisaKvittens(doctorAppointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod: {ex.Message}");
            }
        }

        private bool IsValidBesokNummer(string visitNr)
        {
            return visitNr.StartsWith("B-");
        }

        private bool IsValidLakare(NursingStaff doctor)
        {
            return doctor.Profession == "Sjuksköterska";
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
            CreateVisit();
            
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            HanteraBesok hanterabesok = new HanteraBesok();
            hanterabesok.Show();
            this.Close();
        }
    }
}

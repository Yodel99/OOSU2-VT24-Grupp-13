using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatienthanteringALNy;
using PatienthanteringELNy;

namespace PatienthanteringPL
{
    public partial class NewVisit : Form
    {
        GetListsController getListsController = new GetListsController();
        ManageVisitController manageVisitController = new ManageVisitController();
        User ActiveUser { get; }
        public NewVisit(User user)
        {
            InitializeComponent();
            ListPatients();
            ListNurses();
            ModifyDatePicker();
            ActiveUser = user;
        }
        private void RefreshDatagridViewPatient(IList<Patient> patientlista)
        {
            List<object> patienter = new List<object>();

            foreach (Patient patient in patientlista)
            {
                patienter.Add(new { Förnamn = patient.FName, Efternamn = patient.EName, PatientNummer = patient.PatientNr });
            }

            dataGridViewPatients.DataSource = patienter;
        }
        private void RefreshDatagridViewNurses(IList<NursingStaff> nursingStaff)
        {
            List<object> nursingStaffList = new List<object>();

            foreach (NursingStaff nurse in nursingStaff)
            {
                nursingStaffList.Add(new { Förnamn = nurse.FName, Efternamn = nurse.EName, Anställningsnummer =nurse.StaffNr });
            }

            dataGridViewNurses.DataSource = nursingStaffList;
        }
        private void ModifyDatePicker()
        {
            dateTimePickerVisit.Format = DateTimePickerFormat.Custom;
            dateTimePickerVisit.CustomFormat = "yyyy-MM-dd HH:mm";


            dateTimePickerVisit.ShowUpDown = true;
        }
        private void ListPatients()
        {
            IList<Patient> patients = getListsController.GetPatients();

            RefreshDatagridViewPatient(patients);
        }
        private void ListNurses()
        {
            IList<NursingStaff> nurses = getListsController.GetNursingStaffs();
            RefreshDatagridViewNurses(nurses);
        }
        private void CreateVisit()
        {
            
            string staffNrNurse = textBoxANummerLakare.Text.ToUpper();
            string patientNr = textBoxPatientNummer.Text.ToUpper();
            string reason = textBoxSyfte.Text;
            DateTime date = dateTimePickerVisit.Value;
            string visitNr = textBoxBesokNummer.Text.ToUpper();

            try
            {
                NursingStaff doctor = manageVisitController.GetDoctor(staffNrNurse);
                Patient patient = manageVisitController.GetPatient(patientNr);
                DoctorAppointment doctorAppointmentCheck = manageVisitController.GetVisit(visitNr);

                if (doctorAppointmentCheck!=null||doctor == null || patient == null || !IsValidVisitNr(visitNr) || !IsValidNurse(doctor))
                {
                    MessageBox.Show("Felaktigt ifyllt fält, Var god att kontrollera");
                    return;
                }

                DoctorAppointment doctorAppointment = new DoctorAppointment(visitNr, date, reason, patient, doctor);
                manageVisitController.AddVisit(doctorAppointment);
                ShowReceipt(doctorAppointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod: {ex.Message}");
            }
        }

        private bool IsValidVisitNr(string visitNr)
        {
            return visitNr.StartsWith("B-");
        }

        private bool IsValidNurse(NursingStaff nurse)
        {
            return nurse.Profession == "Sjuksköterska";
        }
        private void ShowReceipt(DoctorAppointment doctorsappointment)
        {
            ReceiptVisit receiptVisit = new ReceiptVisit(doctorsappointment);
            receiptVisit.Show();
            this.Close();
        }

        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            CreateVisit();
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManageVisits manageVisits = new ManageVisits(ActiveUser);
            manageVisits.Show();
            this.Close();
        }
    }
}

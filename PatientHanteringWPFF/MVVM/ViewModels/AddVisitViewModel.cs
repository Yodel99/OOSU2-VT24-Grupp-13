using EnityLayer;
using PatientHanteringWPFF.Core;
using PatientHanteringWPFF.MVVM.Veiw;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    internal class AddVisitViewModel : ObservableObject
    {
        #region Initiatiion of objects
        GetListsController getListsController = new GetListsController();
        private ObservableCollection<Patient> patients = null;
        public ObservableCollection<Patient> Patients
        {
            get { return patients; }
            set
            {
                patients = value;
                OnPropertyChanged(nameof(Patients));
            }
        }
        private ObservableCollection<Patient> filteredPatients;
        public ObservableCollection<Patient> FilteredPatients
        {
            get { return filteredPatients; }
            set
            {
                filteredPatients = value;
                OnPropertyChanged(nameof(FilteredPatients));
            }
        }
        private ObservableCollection<NursingStaff> nurses = null;
        public ObservableCollection<NursingStaff> Nurses
        {
            get { return nurses; }
            set 
            {
                nurses = value;
                OnPropertyChanged(nameof(Nurses));
            }
        }
        private ObservableCollection<NursingStaff> filteredNurses;
        public ObservableCollection<NursingStaff> FilteredNurses
        {
            get { return filteredNurses; }
            set
            {
                filteredNurses = value;
                OnPropertyChanged(nameof(FilteredNurses));
            }
        }
        private Patient patientSelectedItem;
        public Patient PatientSelectedItem
        {
            get { return patientSelectedItem; }
            set
            {
                patientSelectedItem = value;
                OnPropertyChanged(nameof(PatientSelectedItem));
            }
        }
        private NursingStaff nurseSelectedItem;
        public NursingStaff NurseSelectedItem
        {
            get { return nurseSelectedItem; }
            set
            {
                nurseSelectedItem = value;
                OnPropertyChanged(nameof(NurseSelectedItem));
            }
        }
        private string searchTextPatient;
        public string SearchTextPatient
        {
            get { return searchTextPatient; }
            set
            {
                if (searchTextPatient != value)
                {
                    searchTextPatient = value;
                    ApplyFilterPatients();
                    OnPropertyChanged(nameof(SearchTextPatient));

                }

            }
        }
        private string searchTextNurse;
        public string SearchTextNurse
        {
            get { return searchTextNurse; }
            set
            {
                if (searchTextNurse != value)
                {
                    searchTextNurse = value;
                    ApplyFilterNurses();
                    OnPropertyChanged(nameof(SearchTextNurse));
                }
            }
        }
        private string reasonText;
        public string ReasonText
        {
            get { return reasonText; }
            set
            {
                if (reasonText != value)
                {
                    reasonText = value;

                    OnPropertyChanged(nameof(reasonText));
                }
            }
        }
        private int selectedHour;
        public int SelectedHour
        {
            get { return selectedHour; }
            set
            {
                selectedHour = value;
                OnPropertyChanged(nameof(SelectedHour));
            }
        }

        private int selectedMinute;
        public int SelectedMinute
        {
            get { return selectedMinute; }
            set
            {
                selectedMinute = value;
                OnPropertyChanged(nameof(SelectedMinute));
            }
        }
        private DateTime selectedDate;
        public DateTime SelectedDate
        {
            get { return selectedDate; }
            set
            {
                selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
            }
        }
        public List<int> Hours { get; } = Enumerable.Range(8, 11).SelectMany(h => new[] { h }).ToList();
        public List<int> Minutes { get; } = new List<int> { 0, 15, 30, 45 };
        public DateTime CombinedDateTime
        {
            get { return new DateTime(SelectedDate.Year, SelectedDate.Month, SelectedDate.Day, SelectedHour, SelectedMinute, 0); }
        }
        public ICommand SearchCommand { get; private set; }
        public ICommand CreateVisitCommand { get; private set; }
        #endregion
        #region Constructor
        public AddVisitViewModel()
        {
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
            FilteredPatients = new ObservableCollection<Patient>(Patients); 
            Nurses = new ObservableCollection<NursingStaff>(getListsController.GetNursingStaffs());
            FilteredNurses = new ObservableCollection<NursingStaff>(Nurses);
            SelectedDate = DateTime.Today;
            SearchCommand = new RelayCommand(Search);
            CreateVisitCommand = new RelayCommand(param => CreateVisit());
        }
        #endregion
        #region Methods
        private void Search(object parameter)
        {
            ApplyFilterPatients();
            ApplyFilterNurses();
        }

        private void ApplyFilterPatients()
        {
            if (SearchTextPatient==null)
            {
                FilteredPatients = new ObservableCollection<Patient>(Patients);
                return;
            }
            else
            FilteredPatients.Clear();
            foreach (var patient in Patients)
            {
                if (patient.FName.Contains(SearchTextPatient) || patient.EName.Contains(SearchTextPatient))
                {
                    FilteredPatients.Add(patient);
                }
            }
            OnPropertyChanged(nameof(FilteredPatients));
        }
        private void ApplyFilterNurses()
        {
            if (SearchTextNurse==null)
            {
                FilteredNurses = new ObservableCollection<NursingStaff>(Nurses);
                return;
            }
            else 
            FilteredNurses.Clear();
            foreach (var nurse in Nurses)
            {
                if (nurse.FName.Contains(SearchTextNurse) || nurse.EName.Contains(SearchTextNurse))
                {
                    
                    FilteredNurses.Add(nurse);
                }
            }
            OnPropertyChanged(nameof(FilteredNurses));
        }
       
        private void CreateVisit()
        {
            
            ManageVisitController manageVisitController = new ManageVisitController();
            DoctorAppointment doctorAppointment = new DoctorAppointment();
            doctorAppointment.Patient = PatientSelectedItem;
            doctorAppointment.ResponsibleNurse = NurseSelectedItem;
            doctorAppointment.Date = CombinedDateTime;
            doctorAppointment.Reason = reasonText;
            doctorAppointment.VisitNr = manageVisitController.GenerateNewVisitNr();
            doctorAppointment.AppointmentNote = "NoNote";
            doctorAppointment.AppointmentStatus = "FirstVisit";
            manageVisitController.AddVisit(doctorAppointment);
            
            MessageBox.Show($"Doctor Appointment added\n" +
                $"{doctorAppointment.PatientFname} {doctorAppointment.PatientEname}\n" +
                $"{doctorAppointment.ResponsibleNurse.FName} {doctorAppointment.ResponsibleNurse.EName}\n" +
                $"{doctorAppointment.Date}");
        }
        #endregion
    }

}

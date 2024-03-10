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
using System.Windows.Input;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    internal class AddVisitViewModel : ObservableObject
    {
        GetListsController getListsController;
        private ObservableCollection<Patient> patients = null;
        private ObservableCollection<NursingStaff> nurses = null;
        private string searchText;
        private ObservableCollection<Patient> filteredPatients;
        private ObservableCollection<NursingStaff> filteredNurses;

        public ObservableCollection<Patient> Patients
        {
            get { return patients; }
            set
            {
                patients = value;
                OnPropertyChanged(nameof(Patients));
            }
        }

        public ObservableCollection<Patient> FilteredPatients
        {
            get { return filteredPatients; }
            set
            {
                filteredPatients = value;
                OnPropertyChanged(nameof(FilteredPatients));
            }
        }

        public ObservableCollection<NursingStaff> Nurses
        {
            get { return nurses; }
            set 
            {
                nurses = value;
                OnPropertyChanged(nameof(Nurses));
            }
        }
        public ObservableCollection<NursingStaff> FilteredNurses
        {
            get { return filteredNurses; }
            set
            {
                filteredNurses = value;
                OnPropertyChanged(nameof(FilteredNurses));
            }
        }

        public AddVisitViewModel()
        {
            getListsController = new GetListsController();
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
            FilteredPatients = new ObservableCollection<Patient>(Patients); 
            Nurses = new ObservableCollection<NursingStaff>(getListsController.GetNursingStaffs());
            FilteredNurses = new ObservableCollection<NursingStaff>(Nurses);
            SelectedDate = DateTime.Today;
            SearchCommand = new RelayCommand(Search);
            CreateVisitCommand = new RelayCommand(param => CreateVisit());
        }
        private Patient _patientSelectedItem;
        public Patient PatientSelectedItem
        {
            get { return _patientSelectedItem; }
            set
            {
                _patientSelectedItem = value;
                OnPropertyChanged(nameof(PatientSelectedItem));
            }
        }
        private NursingStaff _nurseSelectedItem;
        public NursingStaff NurseSelectedItem
        {
            get { return _nurseSelectedItem; }
            set
            {
                _nurseSelectedItem = value;
                OnPropertyChanged(nameof(NurseSelectedItem));
            }
        }


        public string SearchTextPatient
        {
            get { return searchText; }
            set
            {
                if (searchText != value)
                {
                    searchText = value;
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
        private int _selectedHour;
        public int SelectedHour
        {
            get { return _selectedHour; }
            set
            {
                _selectedHour = value;
                OnPropertyChanged(nameof(SelectedHour));
            }
        }

        private int _selectedMinute;
        public int SelectedMinute
        {
            get { return _selectedMinute; }
            set
            {
                _selectedMinute = value;
                OnPropertyChanged(nameof(SelectedMinute));
            }
        }
        public DateTime CombinedDateTime
        {
            get { return new DateTime(SelectedDate.Year, SelectedDate.Month, SelectedDate.Day, SelectedHour, SelectedMinute, 0); }
        }
        public ICommand CreateVisitCommand { get; private set; }
        private void CreateVisit()
        {
            
            ManageVisitController manageVisitController = new ManageVisitController();
            DoctorAppointment doctorAppointment = new DoctorAppointment();
            doctorAppointment.Patient = PatientSelectedItem;
            doctorAppointment.ResponsibleNurse = NurseSelectedItem;
            doctorAppointment.Date = CombinedDateTime;
            doctorAppointment.Reason = reasonText;
            doctorAppointment.VisitNr = manageVisitController.GenerateNewVisitNr();
            manageVisitController.AddVisit(doctorAppointment);
            
            MessageBox.Show($"Doctor Appointment added\n" +
                $"{doctorAppointment.PatientFNamn} {doctorAppointment.PatientEname}\n" +
                $"{doctorAppointment.ResponsibleNurse.FName} {doctorAppointment.ResponsibleNurse.EName}\n" +
                $"{doctorAppointment.Date}");
        }
       
        public List<int> Hours { get; } = Enumerable.Range(8, 11).SelectMany(h => new[] { h}).ToList();
        public List<int> Minutes { get; } = new List<int> { 0, 15, 30, 45 };
        private DateTime _selectedDate;
        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
            }
        }




        public ICommand SearchCommand { get; private set; }

       

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

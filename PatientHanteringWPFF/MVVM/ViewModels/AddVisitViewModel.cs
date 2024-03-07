using EnityLayer;
using PatientHanteringWPFF.Core;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            SearchCommand = new RelayCommand(Search);
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
                    //ApplyFilterNurses();
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

        public ICommand SearchCommand { get; private set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

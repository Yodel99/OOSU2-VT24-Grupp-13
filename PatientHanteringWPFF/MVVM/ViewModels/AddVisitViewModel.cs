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
        private string _searchText;
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
                nurses = value;
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

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                ApplyFilterPatients();
                ApplyFilterNurses();
                OnPropertyChanged(nameof(SearchText));
                
            }
        }

        private void Search(object parameter)
        {
            ApplyFilterPatients();
            ApplyFilterNurses();
        }

        private void ApplyFilterPatients()
        {
            if (SearchText==null)
            {
                FilteredPatients = new ObservableCollection<Patient>(Patients);
                return;
            }
            else
            FilteredPatients.Clear();
            foreach (var patient in Patients)
            {
                if (patient.FName.Contains(SearchText) || patient.EName.Contains(SearchText))
                {
                    FilteredPatients.Add(patient);
                }
            }
            OnPropertyChanged(nameof(FilteredPatients));
        }
        private void ApplyFilterNurses()
        {
            if (string.IsNullOrEmpty(SearchText))
            {
                FilteredNurses = new ObservableCollection<NursingStaff>(Nurses);
                return;
            }

            // Rensa befintliga filtrerade sjuksköterskor och lägg till nya filtrerade sjuksköterskor
            FilteredNurses.Clear();
            foreach (var nurse in Nurses)
            {
                if (nurse.FName.Contains(SearchText) || nurse.EName.Contains(SearchText))
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
            MessageBox.Show($"Property {propertyName}");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

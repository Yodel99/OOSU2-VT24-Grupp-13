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
using System.Windows.Input;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    internal class AddVisitViewModel : ObservableObject
    {
        GetListsController getListsController;
        private ObservableCollection<Patient> patients = null;
        private List<NursingStaff> nurses = null;
        private string _searchText;
        private ObservableCollection<Patient> filteredPatients; // Separat backing-fält för den filtrerade listan

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

        public List<NursingStaff> Nurses
        {
            get => nurses;
            set { nurses = value; }
        }

        public AddVisitViewModel()
        {
            getListsController = new GetListsController();
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
            FilteredPatients = new ObservableCollection<Patient>(Patients); // Initiera FilteredPatients med samma data som Patients
            nurses = new List<NursingStaff>();
            SearchCommand = new RelayCommand(Search);
        }

        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
                ApplyFilter(); // Funktion för att filtrera listan när söktexten ändras
            }
        }

        private void Search(object parameter)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (string.IsNullOrEmpty(SearchText))
            {
                FilteredPatients = new ObservableCollection<Patient>(Patients);
                return;
            }

            // Rensa befintliga filtrerade patienter och lägg till nya filtrerade patienter
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


        public ICommand SearchCommand { get; private set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

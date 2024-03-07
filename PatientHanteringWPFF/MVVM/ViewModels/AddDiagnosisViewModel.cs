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
    internal class AddDiagnosisViewModel : ObservableObject
    {
        private GetListsController getListsController;
        private CreateDiagnosisController createDiagnosisController;
        
        private string searchTerm;
        public string SearchTerm
        {
            get { return searchTerm; }
            set
            {
                if (searchTerm != value)
                {
                    searchTerm = value;
                    FilterPatients();
                    OnPropertyChanged(nameof(SearchTerm));
                }
            }
        }
        private string diagnosisDescription;
        public string DiagnosisDescription
        {
            get { return diagnosisDescription; }
            set { diagnosisDescription = value; OnPropertyChanged(nameof(DiagnosisDescription)); }
        }

        private string treatmentPlan;
        public string TreatmentPlan
        {
            get { return treatmentPlan; }
            set { treatmentPlan = value; OnPropertyChanged(nameof(TreatmentPlan)); }
        }

        //vald patient i Comboboxen
        private Patient patientSelectedItem = null!;
        public Patient PatientSelectedItem
        {
            get { return patientSelectedItem; }
            set
            {
                patientSelectedItem = value;
                OnPropertyChanged();
                UpdateDiagnoses();
            }
        }

        private ObservableCollection<Patient> patients;
        public ObservableCollection<Patient> Patients
        {
            get { return patients; }
            set
            {
                patients = value;
                OnPropertyChanged(nameof(Patients));
                FilterPatients();
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

        private ObservableCollection<Diagnosis> diagnosis;
        public ObservableCollection<Diagnosis> Diagnosis
        {
            get { return diagnosis; }
            set
            {
                diagnosis = value;
                OnPropertyChanged(nameof(Diagnosis));               
            }
        }

        public ICommand CreateDiagnosisCommand { get; private set; }

        public AddDiagnosisViewModel()
        {
            getListsController = new GetListsController();
            createDiagnosisController = new CreateDiagnosisController();
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());            
            CreateDiagnosisCommand = new RelayCommand(param => CreateDiagnosis());
                       
        }
        
        private void FilterPatients()
        {
            if (string.IsNullOrWhiteSpace(SearchTerm))
            {
                FilteredPatients = Patients;
            }
            else
            {
                FilteredPatients = new ObservableCollection<Patient>(
                    Patients.Where(patient => patient.PatientNr.ToLower().Contains(SearchTerm.ToLower())));
            }
        }

        private void CreateDiagnosis()
        {            
            createDiagnosisController.CreateDiagnosis(PatientSelectedItem, TreatmentPlan, DiagnosisDescription);
            UpdateDiagnoses();
        }
        private void UpdateDiagnoses()
        {
            
            if (PatientSelectedItem != null)
            {
                
                Diagnosis = new ObservableCollection<Diagnosis>(getListsController.GetDiagnosis(PatientSelectedItem));
            }
            else
            {
                Diagnosis.Clear();
            }
        }


    }
}
